using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Romana_Vendimia.Modelo
{
    public static class ScreenManager
    {
        public static Screen[] Pantallas = Screen.AllScreens;
        private static readonly string PathLog = @"C:/ROMANA/LOG/LOG.txt";
        private static readonly string PathScreens = @"C:/ROMANA/PANTALLAZOS/";

        public static bool TieneMasDeUnaPantalla() => Pantallas.Length > 1 ? true : false;

        public static bool CheckFolder_Pantallazos() => Directory.Exists(PathScreens) ? true : false;

        public static void EscribirEnLog(string Texto)
        {
            string[] NuevaLinea = new string[] { DateTime.Now.ToString() + " " + Texto };
            File.AppendAllLines(PathLog, NuevaLinea);
        }

        public static void TomarPantallazoCompletoCierre(Session _session)
        {
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;
            if (CheckFolder_Pantallazos())
            {
                if (TieneMasDeUnaPantalla())
                {
                    //Rectangle bounds = Screen.AllScreens.Bounds;
                    var ScreenShot = new Bitmap(screenWidth, screenHeight,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var gfxScreenShot = Graphics.FromImage(ScreenShot);
                    gfxScreenShot.CopyFromScreen(
                                                screenLeft,
                                                screenTop,
                                                0,
                                                0,
                                                ScreenShot.Size,
                                                CopyPixelOperation.SourceCopy);
                    ScreenShot.Save(PathScreens + "Guardado.png", ImageFormat.Png);
                    _session.Imagen = ObtenerBytes_Imagen(PathScreens + "Guardado.png");

                }
                else
                {
                    EscribirEnLog("No tiene más de una pantalla conectada. " +
                        "Se tomará Pantallazo a Ventana Trabajador");
                    #region Toma Pantallazo a la Ventana Trabajador
                    Rectangle bounds = Pantallas[0].Bounds;
                    var ScreenShot = new Bitmap(bounds.Width, bounds.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var gfxScreenShot = Graphics.FromImage(ScreenShot);
                    gfxScreenShot.CopyFromScreen(
                                                bounds.X,
                                                bounds.Y,
                                                0,
                                                0,
                                                bounds.Size,
                                                CopyPixelOperation.SourceCopy);
                    ScreenShot.Save(PathScreens + "Guardado.png", ImageFormat.Png);
                    _session.Imagen = ObtenerBytes_Imagen(PathScreens + "Guardado.png");
                    #endregion
                }
            }
        }

        public static void TomarPantallazo(Session _session)
        {
            if (CheckFolder_Pantallazos())
            {
                if (TieneMasDeUnaPantalla())
                {
                    Rectangle bounds = Pantallas[1].Bounds;
                    var ScreenShot = new Bitmap(bounds.Width, bounds.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var gfxScreenShot = Graphics.FromImage(ScreenShot);
                    gfxScreenShot.CopyFromScreen(
                                                bounds.X,
                                                bounds.Y,
                                                0,
                                                0,
                                                bounds.Size,
                                                CopyPixelOperation.SourceCopy);
                    ScreenShot.Save(PathScreens + "Guardado.png", ImageFormat.Png);
                    _session.Imagen = ObtenerBytes_Imagen(PathScreens + "Guardado.png");

                }
                else
                {
                    EscribirEnLog("No tiene más de una pantalla conectada. " +
                        "Se tomará Pantallazo a Ventana Trabajador");
                    #region Toma Pantallazo a la Ventana Trabajador
                    Rectangle bounds = Pantallas[0].Bounds;
                    var ScreenShot = new Bitmap(bounds.Width, bounds.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var gfxScreenShot = Graphics.FromImage(ScreenShot);
                    gfxScreenShot.CopyFromScreen(
                                                bounds.X,
                                                bounds.Y,
                                                0,
                                                0,
                                                bounds.Size,
                                                CopyPixelOperation.SourceCopy);
                    ScreenShot.Save(PathScreens + "Guardado.png", ImageFormat.Png);
                    _session.Imagen = ObtenerBytes_Imagen(PathScreens + "Guardado.png");
                    #endregion
                }
            }
            else
            {
                EscribirEnLog("No existe la Carpeta pantallazos en el disco local.");
            }
        }

        public static void CheckeoCarpetas()
        {
            if (!Directory.Exists("C:/ROMANA"))
            {
                Directory.CreateDirectory("C:/ROMANA");
                Directory.CreateDirectory("C:/ROMANA/PANTALLAZOS");
                Directory.CreateDirectory("C:/ROMANA/LOG");
                File.Create("C:/ROMANA/LOG/LOG.txt");
                Directory.CreateDirectory("C:/ROMANA/DB");
                File.WriteAllText("C:/ROMANA/config.txt","[ID_PLANTA];[ID_PROCESO]");
                MessageBox.Show("Se han creado las carpetas y archivos necesarios. Sin embargo, DEBE MODIFICAR " +
                    "EL ARCHIVO config encontrado en \"C:/ROMANA/config.txt\" y escribir el ID_Planta y Tipo_Proceso." +
                    "La aplicación ahora se cerrará para que modifique estos archivos.","PRIMER INICIO DE LA APLICACIÓN",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                EscribirEnLog("Carpetas checkeadas");
            }
        }

        public static byte[] ObtenerBytes_Imagen(string Path)
        {
            byte[] _imageByte;
            using (Image newImage = new Bitmap(Path))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    newImage.Save(ms, ImageFormat.Png);
                    _imageByte = ms.ToArray();
                    return _imageByte;
                }
            }
        }
    
    }
}
