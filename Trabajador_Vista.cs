using Microsoft.Win32;
using Romana_Vendimia.Modelo;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Romana_Vendimia
{
    public partial class Romanero_Vista : Form
    {
        #region CODIGO C++ DLL
        const int WM_SYSCOMMAND = 0x112;
        const int SC_MONITORPOWER = 0xF170;
        const int MONITOR_ON = -1;
        const int MONITOR_OFF = 2;
        const int MONITOR_STANBY = 1;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd,int wMsg,IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        #endregion

        private readonly Cooperado_Vista _cooperado;
        private readonly Screen[] _screen = Screen.AllScreens;
        private static readonly string PathLog = @"C:/ROMANA/LOG/log.txt";
        private Session _MarcasUsuario = new Session();
        private static readonly string ConfigPath = @"C:/ROMANA/config.txt";
        private static string Nombre_Planta = string.Empty;

        #region Variables PuertoSerial
        string strBufferIn = string.Empty;
        string strBufferOut = string.Empty;
        private delegate void DelegadoAcceso(string Accion);

        #endregion

        public Romanero_Vista()
        {
            InitializeComponent();
            SQLiteManager.CheckFolders();
            _cooperado = new Cooperado_Vista();
            SetearSegundaPantalla();
            SetearFechaHora();
            SetearNombrePlanta();
            _cooperado.PlantaInfo.Text = Nombre_Planta;
            PlantaInfo.Text = Nombre_Planta;
            WindowState = FormWindowState.Minimized;
            //SetStartUp();
            OracleManager.SetConfiguracionDePuerto(PuertoSerial,_MarcasUsuario.ID_Planta,2);
            TopMost = true;
            _cooperado.TopMost = true;
            try
            {
                PuertoSerial.Open();
            }
            catch (Exception _error)
            {
                MessageBox.Show("Configuración del Serial Incorrecta. Error: " + _error.Message, "ERROR FATAL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //EscribirEnLog(GetExecutingDirectoryName());
            //PowerModeChangedEventHandler += new SystemEvents_PowerModeChanged();
        }

        public static string GetExecutingDirectoryName()
        {
            try
            {
                var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
                return new FileInfo(location.AbsolutePath).Directory.FullName;
            }
            catch(Exception e)
            {
                return "ERROR : "+e.Message;
            }
        }
        
        private void SetearNombrePlanta()
        {
            Nombre_Planta = OracleManager.ObtenerNombrePlanta(ObtenerID_Planta());
        }

        private int ObtenerID_Planta()
        {
            if (File.Exists(ConfigPath))
            {
                var data = File.ReadAllText(ConfigPath).Split(';');
                _MarcasUsuario.ID_Planta = Convert.ToInt32(data[0]);
                return _MarcasUsuario.ID_Planta;
            }
            else
            {
                EscribirEnLog("Error al leer el archivo de Configuración.");
                return 1;
            }
        }

        private void SetearSegundaPantalla()
        {
            Rectangle bounds;
            if (_screen.Length > 1)
            {
                bounds = _screen[1].Bounds;
                _cooperado.SetBounds(bounds.X,bounds.Y,900,900);
                _cooperado.StartPosition = FormStartPosition.Manual;
                _cooperado.Show();
                _cooperado.WindowState = FormWindowState.Maximized;
            }
            else
            {
                _cooperado.WindowState = FormWindowState.Minimized;
                _cooperado.Hide();
                EscribirEnLog("No existe una segunda pantalla, no se puede abrir la segunda vista.");
            }
        }

        private void Limpiar_UI()
        {
            _cooperado.PesoText.Text = "0";
            _cooperado.TicketInfo.Text = "Ticket : 0";
            TicketInfo.Text = "Ticket : 0";
            PesoText.Text = "0";
        }

        private void AccesoForm(string Data)
        {
            strBufferIn = Data;
            _cooperado.PesoText.Text = strBufferIn;
            PesoText.Text = strBufferIn;
            _MarcasUsuario.Peso = Convert.ToInt32(strBufferIn);
        }

        private void SetStartUp()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false);
                rk.SetValue("Romana", Application.ExecutablePath);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al Escribir en Registro de Windows.","Error",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                EscribirEnLog("Error en clave del registro. Error: "+error.Message);
            }
        }

        private void AccesoInterrupcion(string Data)
        {
            DelegadoAcceso var_Delegado = new DelegadoAcceso(AccesoForm);
            object[] arg = { Data };
            base.Invoke(var_Delegado,arg);
        }

        private void EscribirEnLog(string Texto)
        {
            string[] NuevaLinea = new string[] { DateTime.Now.ToString() + " " + Texto };
            File.AppendAllLines(PathLog, NuevaLinea);
        }

        private void SetearFechaHora()
        {
            FechaHoraInfo.Text = DateTime.Now.ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void ActualizarUI(Session _userSession)
        {
            if (_userSession.Ticket > 0)
            {
                TicketInfo.Text = "Ticket : " + _userSession.Ticket.ToString();
                _cooperado.TicketInfo.Text = "Ticket : " + _userSession.Ticket.ToString();
            }
            else
            {
                TicketInfo.Text = "Ticket : Cross-Docking";
                _cooperado.TicketInfo.Text = "Ticket : Cross-Docking";
            }
            PlantaInfo.Text = _userSession.Nombre_Planta;
            _cooperado.PlantaInfo.Text = _userSession.Nombre_Planta;
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            FechaHoraInfo.Text = DateTime.Now.ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
            if (SQLiteManager.DebeEjecutarse())
            {
                TopMost = true;
                Show();
                //SendMessage(_cooperado.Handle, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)MONITOR_ON);
                RomaneroIcon.Visible = false;
                SetearSegundaPantalla();
                SQLiteManager.CambiarEstado_App(2);
                this.WindowState = FormWindowState.Maximized;
                SQLiteManager.Configurar_Session(ref _MarcasUsuario);
                OracleManager.VerificarIntegridadBaseDeDatos(_MarcasUsuario.ID_Planta);
                SQLiteManager.EliminarRegistro(_MarcasUsuario.Ticket,_MarcasUsuario.ID_Planta);
                MinimizeBox = false;
                ActualizarUI(_MarcasUsuario);
            }
            if (SQLiteManager.DebeMinimizarse())
            {
                Limpiar_UI();
                WindowState = FormWindowState.Minimized;
            }
            if (_cooperado.WindowState != FormWindowState.Maximized)
            {
                //_cooperado.WindowState = FormWindowState.Maximized;
            }
            if (SQLiteManager.AplicacionEnEjecucion())
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
            if (WindowState != FormWindowState.Minimized)
            {
                if (_MarcasUsuario.Ticket == 0)
                {
                    WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void DataRecibida(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //RECIBI DATA xdddd
            try
            {
                switch (_MarcasUsuario.ID_Planta)
                {
                    case 0:
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion("00,0");
                        break;
                    case 1:
                        PuertoSerial.ReadLine();
                        PuertoSerial.ReadLine();
                        var Vicuna = PuertoSerial.ReadLine();
                        Vicuna = Vicuna.ToLower();
                        Vicuna = Vicuna.Replace(" ", "");
                        Vicuna = Vicuna.Substring(0, Vicuna.IndexOf(Properties.Settings.Default.Valor_Anexado));
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Vicuna);
                        break;

                    case 2:
                        PuertoSerial.ReadLine();
                        PuertoSerial.ReadLine();
                        var Salamanca = PuertoSerial.ReadLine();
                        Salamanca = Salamanca.ToLower();
                        Salamanca = Salamanca.Replace(" ", "");
                        Salamanca = Salamanca.Substring(0,Salamanca.IndexOf("kg"));
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Salamanca);
                        break;
                    case 3:
                        PuertoSerial.ReadLine();
                        PuertoSerial.ReadLine();
                        var Sotaqui = PuertoSerial.ReadLine();
                        Sotaqui = Sotaqui.ToLower();
                        Sotaqui = Sotaqui.Replace(" ", "");
                        Sotaqui = Sotaqui.Substring(0, Sotaqui.IndexOf(Properties.Settings.Default.Valor_Anexado));
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Sotaqui);
                        break;
                    case 4:
                        var AltoDelCarmen = PuertoSerial.ReadLine();
                        AltoDelCarmen = AltoDelCarmen.ToLower().Replace(" ","");
                        AltoDelCarmen = AltoDelCarmen.Substring(0,AltoDelCarmen.IndexOf("kg"));
                        AltoDelCarmen = AltoDelCarmen.Replace("kg","");
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(AltoDelCarmen);
                        break;
                    case 5:
                        var Prueba1 = PuertoSerial.ReadLine();
                        var Prueba2 = PuertoSerial.ReadLine();
                        var Copiapo = PuertoSerial.ReadLine();
                        Copiapo = Copiapo.ToLower().Replace(" ", "");
                        Copiapo = Copiapo.Substring(0, Copiapo.IndexOf("kg"));
                        EscribirEnLog(Copiapo);
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Copiapo);
                        break;
                    case 6:
                        var Hurtado = PuertoSerial.ReadLine();
                        var Aux1 = PuertoSerial.ReadLine();
                        var Aux2 = PuertoSerial.ReadLine();
                        var Hurta2 = Hurtado.Replace("Gross:","").Trim();
                        var HurtadoFinal = Hurta2.Replace("kg", "").Trim();
                        AccesoInterrupcion(HurtadoFinal);
                        break;
                    case 7:
                        PuertoSerial.ReadLine();
                        PuertoSerial.ReadLine();
                        var Montegrande = PuertoSerial.ReadLine();
                        Montegrande = Montegrande.ToLower().Replace(" ","");
                        Montegrande = Montegrande.Substring(0,Montegrande.IndexOf("kg"));
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Montegrande);
                        break;
                    case 8:
                        var Chimba = PuertoSerial.ReadExisting();
                        //Chimba = Chimba.Split(new char[0])[0];
                        Chimba = Chimba.Trim();
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Chimba);
                        break;
                    case 9:
                        //var final = PuertoSerial.ReadExisting();
                        //final = final.Substring(0,final.IndexOf("kg"));
                        //final = final.Replace(" ","").Replace("kg","");
                        //AccesoInterrupcion(final);
                        //break;
                        var Atacama = PuertoSerial.ReadLine();
                        //MessageBox.Show("Linea Entrante: "+Atacama,"Captura");
                        EscribirEnLog(Atacama);
                        PuertoSerial.DiscardInBuffer();
                        //Atacama = Atacama.Substring(0,Atacama.IndexOf("kg"));
                        Atacama = Atacama.ToLower().Replace("kg","").Replace("t","")
                            .Replace("\r","").Replace(" ","");
                        var Numero = Convert.ToInt32(Atacama);
                        if (Numero > 0)
                        {
                            AccesoInterrupcion(Atacama);
                            break;
                        }
                        break;
                        #region codigo descontinuado
                    //EscribirEnLog("Escribiendo Atacama ...");
                    //var DataIn = PuertoSerial.ReadLine();
                    //EscribirEnLog(DataIn);
                    //var Data2 = PuertoSerial.ReadLine();
                    //EscribirEnLog(Data2);
                    //var Data3 = PuertoSerial.ReadLine();
                    //EscribirEnLog(Data3);
                    //EscribirEnLog("Pase los readlines");
                    //File.AppendAllLines("C://ROMANA//transitorio.txt",
                    //    new string[] { DataIn, Data2, Data3 });
                    ////File.AppendAllLines("C://ROMANA//casiFinal.txt",
                    ////    new string[] { VariDataIn });
                    //var final = DataIn.ToLower().Substring(0, DataIn.IndexOf("kg"));
                    //final = final.Replace(" ", "").Replace("kg", "");
                    //File.WriteAllText("C://ROMANA/final.txt", final);
                    #endregion
                    case 10:
                        var Punitaqui = PuertoSerial.ReadLine();
                        Punitaqui = Punitaqui.ToLower().Replace(" ","");
                        Punitaqui = Punitaqui.Substring(0,Punitaqui.IndexOf("kg"));
                        Punitaqui = Punitaqui.Replace("scale1","").Replace("kg","");
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Punitaqui);
                        break;
                    case 15:
                        var RON = PuertoSerial.ReadExisting();
                        //Chimba = Chimba.Split(new char[0])[0];
                        RON = RON.Trim();
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(RON);
                        break;
                    default:
                        var Resultado = PuertoSerial.ReadExisting().Split(new char[0])[0];
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Resultado);
                        break;
                }
                PuertoSerial.DiscardInBuffer();
            }
            catch (Exception _ex)
            {
                EscribirEnLog("Error al Limpiar la Data que ingresa por Puerto Serial. Con el siguiente mensaje " +
                    " "+_ex.Message);
                SQLiteManager.CambiarEstado_App(5);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(PesoText.Text) > 0) {
                try
                {
                    OracleManager.VerificarIntegridadBaseDeDatos(_MarcasUsuario.ID_Planta);
                    _MarcasUsuario.Peso = Convert.ToInt32(PesoText.Text);
                    InsertarEnBasesDeDatos(_MarcasUsuario);
                    Limpiar_UI();
                    MessageBox.Show("Datos Guardados con éxito.Serás redireccionado " +
                        "a la página web.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SQLiteManager.CambiarEstado_App(3);
                    _MarcasUsuario.Clear_Session();
                }
                catch (Exception _error)
                {
                    EscribirEnLog("Error al Ingresar Datos. Error: "+_error.Message);
                    MessageBox.Show("Intermitencia de enlace detectada, pruebe nuevamente.","Información",
                        MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                MessageBox.Show("El peso ingresado no puede ser 0.","Alerta",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void InsertarEnBasesDeDatos(Session _userSession)
        {
            ScreenManager.TomarPantallazo(_userSession);
            SQLiteManager.InsertarDatos(_userSession);
            OracleManager.InsertarDatosEnPasarela(_userSession);
            OracleManager.InsertarFoto(_userSession);
        }

        private void CancelarClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar esta ventana?, El proceso deberá ser " +
                "reiniciado desde la página web.","Confirmar Acción",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Limpiar_UI();
                SQLiteManager.CambiarEstado_App(4);
                OracleManager.InsertarEstadoApp(4,_MarcasUsuario.ID_Planta,2);
            }
            
        }

        private void Closing_Event(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar esta ventana?, El proceso deberá ser " +
                "reiniciado desde la página web.", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Limpiar_UI();
                SQLiteManager.CambiarEstado_App(4);
            }
            else
            {
                e.Cancel = true;
            }
            //new FormularioCierre().Show();
            //e.Cancel = true;
        }

        private void ResizeEvent(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (_MarcasUsuario.Ticket == 0) {
                    Hide();
                    RomaneroIcon.Visible = true;
                    RomaneroIcon.ShowBalloonTip(1500);
                }
            }
            if (WindowState == FormWindowState.Maximized)
            {
                RomaneroIcon.Visible = false;
            }
        }

        private void Romanero_Vista_Load(object sender, EventArgs e)
        {

        }
    }
}
