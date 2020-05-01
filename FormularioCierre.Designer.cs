namespace Romana_Vendimia
{
    partial class FormularioCierre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCierre));
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.motivoLabel = new System.Windows.Forms.Label();
            this.MotivoComboBox = new System.Windows.Forms.ComboBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(1, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(620, 58);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Aviso: Se tomará registros de estas acciones, porfavor verifique que la informaci" +
    "ón entregada corresponda a lo que está sucediendo.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MotivoComboBox);
            this.groupBox1.Controls.Add(this.motivoLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // motivoLabel
            // 
            this.motivoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivoLabel.Location = new System.Drawing.Point(0, 18);
            this.motivoLabel.Name = "motivoLabel";
            this.motivoLabel.Size = new System.Drawing.Size(113, 38);
            this.motivoLabel.TabIndex = 0;
            this.motivoLabel.Text = "Motivo:";
            this.motivoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MotivoComboBox
            // 
            this.MotivoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MotivoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotivoComboBox.FormattingEnabled = true;
            this.MotivoComboBox.Items.AddRange(new object[] {
            "La segunda pantalla no muestra nada.",
            "Término de Jornada.",
            "El Aplicación no captura los Datos.",
            "Se cayó el internet y la Aplicación ya no funciona."});
            this.MotivoComboBox.Location = new System.Drawing.Point(107, 17);
            this.MotivoComboBox.Name = "MotivoComboBox";
            this.MotivoComboBox.Size = new System.Drawing.Size(496, 39);
            this.MotivoComboBox.TabIndex = 1;
            this.MotivoComboBox.Text = "-- Seleccione un Motivo --";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(18, 149);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(245, 43);
            this.CancelarButton.TabIndex = 2;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.Location = new System.Drawing.Point(370, 149);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(245, 43);
            this.AceptarButton.TabIndex = 3;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // FormularioCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 204);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de la Aplicación";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox MotivoComboBox;
        private System.Windows.Forms.Label motivoLabel;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
    }
}