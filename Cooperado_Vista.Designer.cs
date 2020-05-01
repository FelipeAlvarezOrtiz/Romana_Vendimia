namespace Romana_Vendimia
{
    partial class Cooperado_Vista
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cooperado_Vista));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TicketInfo = new System.Windows.Forms.Label();
            this.FechaHoraInfo = new System.Windows.Forms.Label();
            this.PlantaInfo = new System.Windows.Forms.Label();
            this.MidLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.PesoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PesoLabel = new System.Windows.Forms.Label();
            this.PesoText = new System.Windows.Forms.Label();
            this.BottomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.versionInfo = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.CooperadoIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainLayout.SuspendLayout();
            this.TopLayout.SuspendLayout();
            this.MidLayout.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.PesoLayout.SuspendLayout();
            this.BottomLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.TopLayout, 0, 0);
            this.MainLayout.Controls.Add(this.MidLayout, 0, 1);
            this.MainLayout.Controls.Add(this.BottomLayout, 0, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainLayout.Size = new System.Drawing.Size(932, 709);
            this.MainLayout.TabIndex = 0;
            // 
            // TopLayout
            // 
            this.TopLayout.ColumnCount = 2;
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Controls.Add(this.TicketInfo, 0, 1);
            this.TopLayout.Controls.Add(this.FechaHoraInfo, 1, 0);
            this.TopLayout.Controls.Add(this.PlantaInfo, 0, 0);
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLayout.Location = new System.Drawing.Point(4, 4);
            this.TopLayout.Margin = new System.Windows.Forms.Padding(4);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.RowCount = 2;
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Size = new System.Drawing.Size(924, 98);
            this.TopLayout.TabIndex = 0;
            // 
            // TicketInfo
            // 
            this.TicketInfo.AutoSize = true;
            this.TicketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.TicketInfo.Location = new System.Drawing.Point(4, 49);
            this.TicketInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TicketInfo.Name = "TicketInfo";
            this.TicketInfo.Size = new System.Drawing.Size(454, 49);
            this.TicketInfo.TabIndex = 2;
            this.TicketInfo.Text = "Ticket No hay Info";
            this.TicketInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaHoraInfo
            // 
            this.FechaHoraInfo.AutoSize = true;
            this.FechaHoraInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaHoraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaHoraInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.FechaHoraInfo.Location = new System.Drawing.Point(466, 0);
            this.FechaHoraInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaHoraInfo.Name = "FechaHoraInfo";
            this.FechaHoraInfo.Size = new System.Drawing.Size(454, 49);
            this.FechaHoraInfo.TabIndex = 1;
            this.FechaHoraInfo.Text = "Fecha Hora PlaceHolder";
            this.FechaHoraInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlantaInfo
            // 
            this.PlantaInfo.AutoSize = true;
            this.PlantaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlantaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantaInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.PlantaInfo.Location = new System.Drawing.Point(4, 0);
            this.PlantaInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlantaInfo.Name = "PlantaInfo";
            this.PlantaInfo.Size = new System.Drawing.Size(454, 49);
            this.PlantaInfo.TabIndex = 0;
            this.PlantaInfo.Text = "Planta PlaceHolder";
            this.PlantaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MidLayout
            // 
            this.MidLayout.ColumnCount = 3;
            this.MidLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MidLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MidLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MidLayout.Controls.Add(this.bunifuCards1, 1, 0);
            this.MidLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidLayout.Location = new System.Drawing.Point(4, 110);
            this.MidLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MidLayout.Name = "MidLayout";
            this.MidLayout.RowCount = 1;
            this.MidLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MidLayout.Size = new System.Drawing.Size(924, 559);
            this.MidLayout.TabIndex = 1;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.bunifuCards1.Controls.Add(this.PesoLayout);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(50, 4);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(823, 551);
            this.bunifuCards1.TabIndex = 0;
            // 
            // PesoLayout
            // 
            this.PesoLayout.ColumnCount = 1;
            this.PesoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PesoLayout.Controls.Add(this.PesoLabel, 0, 0);
            this.PesoLayout.Controls.Add(this.PesoText, 0, 1);
            this.PesoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PesoLayout.Location = new System.Drawing.Point(0, 0);
            this.PesoLayout.Margin = new System.Windows.Forms.Padding(4);
            this.PesoLayout.Name = "PesoLayout";
            this.PesoLayout.RowCount = 2;
            this.PesoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.PesoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.PesoLayout.Size = new System.Drawing.Size(823, 551);
            this.PesoLayout.TabIndex = 1;
            // 
            // PesoLabel
            // 
            this.PesoLabel.AutoSize = true;
            this.PesoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PesoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.PesoLabel.Location = new System.Drawing.Point(4, 0);
            this.PesoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PesoLabel.Name = "PesoLabel";
            this.PesoLabel.Size = new System.Drawing.Size(815, 68);
            this.PesoLabel.TabIndex = 0;
            this.PesoLabel.Text = "Peso";
            this.PesoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PesoText
            // 
            this.PesoText.AutoSize = true;
            this.PesoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PesoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 199.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.PesoText.Location = new System.Drawing.Point(4, 68);
            this.PesoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PesoText.Name = "PesoText";
            this.PesoText.Size = new System.Drawing.Size(815, 483);
            this.PesoText.TabIndex = 1;
            this.PesoText.Text = "0";
            this.PesoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomLayout
            // 
            this.BottomLayout.ColumnCount = 4;
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.19192F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.64502F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.09812F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92064F));
            this.BottomLayout.Controls.Add(this.versionInfo, 3, 0);
            this.BottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomLayout.Location = new System.Drawing.Point(4, 677);
            this.BottomLayout.Margin = new System.Windows.Forms.Padding(4);
            this.BottomLayout.Name = "BottomLayout";
            this.BottomLayout.RowCount = 1;
            this.BottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomLayout.Size = new System.Drawing.Size(924, 28);
            this.BottomLayout.TabIndex = 2;
            // 
            // versionInfo
            // 
            this.versionInfo.AutoSize = true;
            this.versionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionInfo.Location = new System.Drawing.Point(603, 0);
            this.versionInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionInfo.Name = "versionInfo";
            this.versionInfo.Size = new System.Drawing.Size(317, 28);
            this.versionInfo.TabIndex = 0;
            this.versionInfo.Text = "Version 1.0.1";
            this.versionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // CooperadoIcon
            // 
            this.CooperadoIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CooperadoIcon.BalloonTipText = "Ventana que permite la salida hacia la segunda pantalla";
            this.CooperadoIcon.BalloonTipTitle = "Ventana Cooperado";
            this.CooperadoIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("CooperadoIcon.Icon")));
            this.CooperadoIcon.Text = "Cooperado";
            this.CooperadoIcon.Visible = true;
            // 
            // Cooperado_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 709);
            this.Controls.Add(this.MainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cooperado_Vista";
            this.Text = "Cooperado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Cerrando);
            this.MainLayout.ResumeLayout(false);
            this.TopLayout.ResumeLayout(false);
            this.TopLayout.PerformLayout();
            this.MidLayout.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.PesoLayout.ResumeLayout(false);
            this.PesoLayout.PerformLayout();
            this.BottomLayout.ResumeLayout(false);
            this.BottomLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel TopLayout;
        private System.Windows.Forms.Label FechaHoraInfo;
        private System.Windows.Forms.TableLayoutPanel MidLayout;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.TableLayoutPanel PesoLayout;
        private System.Windows.Forms.Label PesoLabel;
        private System.Windows.Forms.TableLayoutPanel BottomLayout;
        private System.Windows.Forms.Label versionInfo;
        private System.Windows.Forms.Timer Temporizador;
        public System.Windows.Forms.Label PlantaInfo;
        public System.Windows.Forms.Label TicketInfo;
        public System.Windows.Forms.Label PesoText;
        private System.Windows.Forms.NotifyIcon CooperadoIcon;
    }
}