using System;
using System.Windows.Forms;

namespace Romana_Vendimia
{
    public partial class Cooperado_Vista : Form
    {
        public Cooperado_Vista()
        {
            InitializeComponent();
            SetearFechaHora();
        }

        private void SetearFechaHora()
        {
            FechaHoraInfo.Text = DateTime.Now.ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            FechaHoraInfo.Text = DateTime.Now.ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form_Cerrando(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) {
                MessageBox.Show("Esta ventana no puede cerrarse. PROHIBIDO", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
