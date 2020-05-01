namespace Romana_Vendimia
{
    partial class Romanero_Vista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Romanero_Vista));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TicketInfo = new System.Windows.Forms.Label();
            this.PlantaInfo = new System.Windows.Forms.Label();
            this.FechaHoraInfo = new System.Windows.Forms.Label();
            this.Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.MidLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.PesoCard = new Bunifu.Framework.UI.BunifuCards();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PesoText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.RomaneroIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainLayout.SuspendLayout();
            this.TopLayout.SuspendLayout();
            this.MidLayout.SuspendLayout();
            this.ButtonLayout.SuspendLayout();
            this.PesoCard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.TopLayout, 0, 0);
            this.mainLayout.Controls.Add(this.Separator, 0, 1);
            this.mainLayout.Controls.Add(this.MidLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.69627F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.953819F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.34991F));
            this.mainLayout.Size = new System.Drawing.Size(943, 693);
            this.mainLayout.TabIndex = 0;
            // 
            // TopLayout
            // 
            this.TopLayout.ColumnCount = 2;
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.44379F));
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.55621F));
            this.TopLayout.Controls.Add(this.TicketInfo, 0, 1);
            this.TopLayout.Controls.Add(this.PlantaInfo, 0, 0);
            this.TopLayout.Controls.Add(this.FechaHoraInfo, 1, 0);
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLayout.Location = new System.Drawing.Point(3, 2);
            this.TopLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.RowCount = 2;
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Size = new System.Drawing.Size(937, 111);
            this.TopLayout.TabIndex = 0;
            // 
            // TicketInfo
            // 
            this.TicketInfo.AutoSize = true;
            this.TicketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.TicketInfo.Location = new System.Drawing.Point(3, 55);
            this.TicketInfo.Name = "TicketInfo";
            this.TicketInfo.Size = new System.Drawing.Size(466, 56);
            this.TicketInfo.TabIndex = 1;
            this.TicketInfo.Text = "Ticket: No hay Info";
            this.TicketInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlantaInfo
            // 
            this.PlantaInfo.AutoSize = true;
            this.PlantaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlantaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantaInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.PlantaInfo.Location = new System.Drawing.Point(3, 0);
            this.PlantaInfo.Name = "PlantaInfo";
            this.PlantaInfo.Size = new System.Drawing.Size(466, 55);
            this.PlantaInfo.TabIndex = 0;
            this.PlantaInfo.Text = "Planta PlaceHolder";
            this.PlantaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaHoraInfo
            // 
            this.FechaHoraInfo.AutoSize = true;
            this.FechaHoraInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaHoraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaHoraInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.FechaHoraInfo.Location = new System.Drawing.Point(476, 0);
            this.FechaHoraInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaHoraInfo.Name = "FechaHoraInfo";
            this.FechaHoraInfo.Size = new System.Drawing.Size(457, 55);
            this.FechaHoraInfo.TabIndex = 2;
            this.FechaHoraInfo.Text = "Fecha hora Placeholder";
            this.FechaHoraInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator.LineThickness = 1;
            this.Separator.Location = new System.Drawing.Point(5, 120);
            this.Separator.Margin = new System.Windows.Forms.Padding(5);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(933, 3);
            this.Separator.TabIndex = 1;
            this.Separator.Transparency = 255;
            this.Separator.Vertical = false;
            // 
            // MidLayout
            // 
            this.MidLayout.ColumnCount = 3;
            this.MidLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.417974F));
            this.MidLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.73895F));
            this.MidLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.985735F));
            this.MidLayout.Controls.Add(this.ButtonLayout, 1, 1);
            this.MidLayout.Controls.Add(this.PesoCard, 1, 0);
            this.MidLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidLayout.Location = new System.Drawing.Point(4, 132);
            this.MidLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MidLayout.Name = "MidLayout";
            this.MidLayout.RowCount = 3;
            this.MidLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.65022F));
            this.MidLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.76233F));
            this.MidLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.363229F));
            this.MidLayout.Size = new System.Drawing.Size(935, 557);
            this.MidLayout.TabIndex = 2;
            // 
            // ButtonLayout
            // 
            this.ButtonLayout.ColumnCount = 4;
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayout.Controls.Add(this.GuardarButton, 3, 0);
            this.ButtonLayout.Controls.Add(this.CancelarButton, 0, 0);
            this.ButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLayout.Location = new System.Drawing.Point(73, 482);
            this.ButtonLayout.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLayout.Name = "ButtonLayout";
            this.ButtonLayout.RowCount = 1;
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonLayout.Size = new System.Drawing.Size(764, 52);
            this.ButtonLayout.TabIndex = 0;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(577, 4);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(183, 44);
            this.GuardarButton.TabIndex = 0;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelarButton.Location = new System.Drawing.Point(4, 4);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(183, 44);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarClick);
            // 
            // PesoCard
            // 
            this.PesoCard.BackColor = System.Drawing.Color.White;
            this.PesoCard.BorderRadius = 5;
            this.PesoCard.BottomSahddow = true;
            this.PesoCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.PesoCard.Controls.Add(this.tableLayoutPanel1);
            this.PesoCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PesoCard.LeftSahddow = false;
            this.PesoCard.Location = new System.Drawing.Point(73, 4);
            this.PesoCard.Margin = new System.Windows.Forms.Padding(4);
            this.PesoCard.Name = "PesoCard";
            this.PesoCard.RightSahddow = true;
            this.PesoCard.ShadowDepth = 20;
            this.PesoCard.Size = new System.Drawing.Size(764, 470);
            this.PesoCard.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PesoText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 470);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PesoText
            // 
            this.PesoText.AutoSize = true;
            this.PesoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PesoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.PesoText.Location = new System.Drawing.Point(4, 70);
            this.PesoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PesoText.Name = "PesoText";
            this.PesoText.Size = new System.Drawing.Size(756, 400);
            this.PesoText.TabIndex = 0;
            this.PesoText.Text = "0";
            this.PesoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DiscardNull = true;
            this.PuertoSerial.PortName = "COM2";
            this.PuertoSerial.RtsEnable = true;
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataRecibida);
            // 
            // RomaneroIcon
            // 
            this.RomaneroIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.RomaneroIcon.BalloonTipText = "Aplicación de Romanero";
            this.RomaneroIcon.BalloonTipTitle = "Romana";
            this.RomaneroIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("RomaneroIcon.Icon")));
            this.RomaneroIcon.Text = "Romana";
            this.RomaneroIcon.Visible = true;
            // 
            // Romanero_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 693);
            this.Controls.Add(this.mainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Romanero_Vista";
            this.Text = "Romanero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing_Event);
            this.Load += new System.EventHandler(this.Romanero_Vista_Load);
            this.Resize += new System.EventHandler(this.ResizeEvent);
            this.mainLayout.ResumeLayout(false);
            this.TopLayout.ResumeLayout(false);
            this.TopLayout.PerformLayout();
            this.MidLayout.ResumeLayout(false);
            this.ButtonLayout.ResumeLayout(false);
            this.PesoCard.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel TopLayout;
        private System.Windows.Forms.Label PlantaInfo;
        private System.Windows.Forms.Label TicketInfo;
        private System.Windows.Forms.Label FechaHoraInfo;
        private Bunifu.Framework.UI.BunifuSeparator Separator;
        private System.Windows.Forms.TableLayoutPanel MidLayout;
        private System.Windows.Forms.TableLayoutPanel ButtonLayout;
        private System.Windows.Forms.Button CancelarButton;
        private Bunifu.Framework.UI.BunifuCards PesoCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PesoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Temporizador;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.NotifyIcon RomaneroIcon;
        private System.Windows.Forms.Button GuardarButton;
    }
}

