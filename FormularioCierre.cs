using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romana_Vendimia
{
    public partial class FormularioCierre : Form
    {
        public FormularioCierre()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (MotivoComboBox.SelectedIndex >0)
            {

            }
            else
            {
                MessageBox.Show("Porfavor seleccione una opción válida.","Información",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
