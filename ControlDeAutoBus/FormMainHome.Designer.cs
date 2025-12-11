namespace ControlDeAutoBus
{
    partial class FormMainHome
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
            panelLayer = new Panel();
            Ajuste = new FontAwesome.Sharp.IconButton();
            Asignación = new FontAwesome.Sharp.IconButton();
            Rutas = new FontAwesome.Sharp.IconButton();
            Autobuses = new FontAwesome.Sharp.IconButton();
            Choferes = new FontAwesome.Sharp.IconButton();
            Dashboard = new FontAwesome.Sharp.IconButton();
            PanelImage = new Panel();
            BtnHome = new FontAwesome.Sharp.IconPictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            LblHome = new Label();
            IconHome = new FontAwesome.Sharp.IconPictureBox();
            PanelDesktop = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelLayer.SuspendLayout();
            PanelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconHome).BeginInit();
            PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLayer
            // 
            panelLayer.BackColor = Color.MidnightBlue;
            panelLayer.Controls.Add(Ajuste);
            panelLayer.Controls.Add(Asignación);
            panelLayer.Controls.Add(Rutas);
            panelLayer.Controls.Add(Autobuses);
            panelLayer.Controls.Add(Choferes);
            panelLayer.Controls.Add(Dashboard);
            panelLayer.Controls.Add(PanelImage);
            panelLayer.Dock = DockStyle.Left;
            panelLayer.Location = new Point(0, 0);
            panelLayer.Name = "panelLayer";
            panelLayer.Size = new Size(220, 686);
            panelLayer.TabIndex = 0;
            // 
            // Ajuste
            // 
            Ajuste.Cursor = Cursors.Hand;
            Ajuste.Dock = DockStyle.Bottom;
            Ajuste.FlatAppearance.BorderSize = 0;
            Ajuste.FlatStyle = FlatStyle.Flat;
            Ajuste.ForeColor = Color.White;
            Ajuste.IconChar = FontAwesome.Sharp.IconChar.Cog;
            Ajuste.IconColor = Color.White;
            Ajuste.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ajuste.IconSize = 32;
            Ajuste.ImageAlign = ContentAlignment.MiddleLeft;
            Ajuste.Location = new Point(0, 636);
            Ajuste.Name = "Ajuste";
            Ajuste.Padding = new Padding(10, 0, 20, 0);
            Ajuste.Size = new Size(220, 50);
            Ajuste.TabIndex = 10;
            Ajuste.Text = "Ajuste";
            Ajuste.TextAlign = ContentAlignment.MiddleLeft;
            Ajuste.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ajuste.UseVisualStyleBackColor = true;
            Ajuste.Click += Ajuste_Click;
            // 
            // Asignación
            // 
            Asignación.Cursor = Cursors.Hand;
            Asignación.FlatAppearance.BorderSize = 0;
            Asignación.FlatStyle = FlatStyle.Flat;
            Asignación.ForeColor = Color.White;
            Asignación.IconChar = FontAwesome.Sharp.IconChar.ThumbTack;
            Asignación.IconColor = Color.White;
            Asignación.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Asignación.IconSize = 32;
            Asignación.ImageAlign = ContentAlignment.MiddleLeft;
            Asignación.Location = new Point(0, 352);
            Asignación.Name = "Asignación";
            Asignación.Padding = new Padding(10, 0, 20, 0);
            Asignación.Size = new Size(220, 65);
            Asignación.TabIndex = 9;
            Asignación.Text = "Asignación";
            Asignación.TextAlign = ContentAlignment.MiddleLeft;
            Asignación.TextImageRelation = TextImageRelation.ImageBeforeText;
            Asignación.UseVisualStyleBackColor = true;
            Asignación.Click += Asignación_Click;
            // 
            // Rutas
            // 
            Rutas.Cursor = Cursors.Hand;
            Rutas.FlatAppearance.BorderSize = 0;
            Rutas.FlatStyle = FlatStyle.Flat;
            Rutas.ForeColor = Color.White;
            Rutas.IconChar = FontAwesome.Sharp.IconChar.Route;
            Rutas.IconColor = Color.White;
            Rutas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Rutas.IconSize = 32;
            Rutas.ImageAlign = ContentAlignment.MiddleLeft;
            Rutas.Location = new Point(0, 287);
            Rutas.Name = "Rutas";
            Rutas.Padding = new Padding(10, 0, 20, 0);
            Rutas.Size = new Size(220, 65);
            Rutas.TabIndex = 8;
            Rutas.Text = "Rutas";
            Rutas.TextAlign = ContentAlignment.MiddleLeft;
            Rutas.TextImageRelation = TextImageRelation.ImageBeforeText;
            Rutas.UseVisualStyleBackColor = true;
            Rutas.Click += Rutas_Click;
            // 
            // Autobuses
            // 
            Autobuses.Cursor = Cursors.Hand;
            Autobuses.FlatAppearance.BorderSize = 0;
            Autobuses.FlatStyle = FlatStyle.Flat;
            Autobuses.ForeColor = Color.White;
            Autobuses.IconChar = FontAwesome.Sharp.IconChar.Bus;
            Autobuses.IconColor = Color.White;
            Autobuses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Autobuses.IconSize = 32;
            Autobuses.ImageAlign = ContentAlignment.MiddleLeft;
            Autobuses.Location = new Point(0, 222);
            Autobuses.Name = "Autobuses";
            Autobuses.Padding = new Padding(10, 0, 20, 0);
            Autobuses.Size = new Size(220, 65);
            Autobuses.TabIndex = 7;
            Autobuses.Text = "Autobuses";
            Autobuses.TextAlign = ContentAlignment.MiddleLeft;
            Autobuses.TextImageRelation = TextImageRelation.ImageBeforeText;
            Autobuses.UseVisualStyleBackColor = true;
            Autobuses.Click += Autobuses_Click;
            // 
            // Choferes
            // 
            Choferes.Cursor = Cursors.Hand;
            Choferes.FlatAppearance.BorderSize = 0;
            Choferes.FlatStyle = FlatStyle.Flat;
            Choferes.ForeColor = Color.White;
            Choferes.IconChar = FontAwesome.Sharp.IconChar.DriversLicense;
            Choferes.IconColor = Color.White;
            Choferes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Choferes.IconSize = 32;
            Choferes.ImageAlign = ContentAlignment.MiddleLeft;
            Choferes.Location = new Point(0, 157);
            Choferes.Name = "Choferes";
            Choferes.Padding = new Padding(10, 0, 20, 0);
            Choferes.Size = new Size(220, 65);
            Choferes.TabIndex = 6;
            Choferes.Text = "Choferes";
            Choferes.TextAlign = ContentAlignment.MiddleLeft;
            Choferes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Choferes.UseVisualStyleBackColor = true;
            Choferes.Click += Choferes_Click;
            // 
            // Dashboard
            // 
            Dashboard.Cursor = Cursors.Hand;
            Dashboard.FlatAppearance.BorderSize = 0;
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.ForeColor = Color.White;
            Dashboard.IconChar = FontAwesome.Sharp.IconChar.Cube;
            Dashboard.IconColor = Color.White;
            Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Dashboard.IconSize = 32;
            Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard.Location = new Point(0, 92);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(10, 0, 20, 0);
            Dashboard.Size = new Size(220, 65);
            Dashboard.TabIndex = 5;
            Dashboard.Text = "Dashboard";
            Dashboard.TextAlign = ContentAlignment.MiddleLeft;
            Dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            Dashboard.UseVisualStyleBackColor = true;
            Dashboard.Click += Dashboard_Click;
            // 
            // PanelImage
            // 
            PanelImage.Controls.Add(BtnHome);
            PanelImage.Dock = DockStyle.Top;
            PanelImage.Location = new Point(0, 0);
            PanelImage.Name = "PanelImage";
            PanelImage.Size = new Size(220, 92);
            PanelImage.TabIndex = 2;
            // 
            // BtnHome
            // 
            BtnHome.Anchor = AnchorStyles.None;
            BtnHome.BackColor = Color.MidnightBlue;
            BtnHome.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHome.Cursor = Cursors.Hand;
            BtnHome.ForeColor = Color.FromArgb(24, 161, 251);
            BtnHome.IconChar = FontAwesome.Sharp.IconChar.Bus;
            BtnHome.IconColor = Color.FromArgb(24, 161, 251);
            BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnHome.IconSize = 92;
            BtnHome.Location = new Point(0, 0);
            BtnHome.Name = "BtnHome";
            BtnHome.Padding = new Padding(60, 0, 0, 0);
            BtnHome.Size = new Size(220, 92);
            BtnHome.TabIndex = 1;
            BtnHome.TabStop = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(LblHome);
            panel1.Controls.Add(IconHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 80);
            panel1.TabIndex = 1;
            // 
            // LblHome
            // 
            LblHome.AutoSize = true;
            LblHome.ForeColor = Color.White;
            LblHome.Location = new Point(56, 29);
            LblHome.Name = "LblHome";
            LblHome.Size = new Size(50, 20);
            LblHome.TabIndex = 1;
            LblHome.Text = "Home";
            // 
            // IconHome
            // 
            IconHome.BackColor = Color.MidnightBlue;
            IconHome.IconChar = FontAwesome.Sharp.IconChar.House;
            IconHome.IconColor = Color.White;
            IconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconHome.Location = new Point(23, 23);
            IconHome.Name = "IconHome";
            IconHome.Size = new Size(32, 34);
            IconHome.TabIndex = 0;
            IconHome.TabStop = false;
            // 
            // PanelDesktop
            // 
            PanelDesktop.Controls.Add(iconPictureBox1);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(220, 80);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(1320, 606);
            PanelDesktop.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            iconPictureBox1.Cursor = Cursors.Hand;
            iconPictureBox1.ForeColor = Color.FromArgb(24, 161, 251);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bus;
            iconPictureBox1.IconColor = Color.FromArgb(24, 161, 251);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 92;
            iconPictureBox1.Location = new Point(573, 222);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Padding = new Padding(60, 0, 0, 0);
            iconPictureBox1.Size = new Size(220, 92);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // FormMainHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 686);
            Controls.Add(PanelDesktop);
            Controls.Add(panel1);
            Controls.Add(panelLayer);
            Name = "FormMainHome";
            Text = "FormMainHome";
            MouseDown += FormMainHome_MouseDown;
            panelLayer.ResumeLayout(false);
            PanelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconHome).EndInit();
            PanelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLayer;
        private Panel PanelImage;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private FontAwesome.Sharp.IconButton Dashboard;
        private FontAwesome.Sharp.IconButton Ajuste;
        private FontAwesome.Sharp.IconButton Asignación;
        private FontAwesome.Sharp.IconButton Rutas;
        private FontAwesome.Sharp.IconButton Autobuses;
        private FontAwesome.Sharp.IconButton Choferes;
        private FontAwesome.Sharp.IconPictureBox BtnHome;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox IconHome;
        private Label LblHome;
        private Panel PanelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}