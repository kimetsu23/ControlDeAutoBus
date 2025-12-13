using FontAwesome.Sharp;

namespace ControlDeAutoBus
{
    partial class FormMainHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelLayer = new Panel();
            Ajuste = new IconButton();
            Asignación = new IconButton();
            Rutas = new IconButton();
            Autobuses = new IconButton();
            Choferes = new IconButton();
            Dashboard = new IconButton();
            PanelImage = new Panel();
            BtnHome = new IconPictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            panelUser = new Panel();
            btnLogout = new IconButton();
            lblUserRole = new Label();
            lblUserName = new Label();
            iconUser = new IconPictureBox();
            BtnMini = new IconButton();
            BtnBig = new IconButton();
            BtnExit = new IconButton();
            LblHome = new Label();
            IconHome = new IconPictureBox();
            PanelDesktop = new Panel();
            iconPictureBox1 = new IconPictureBox();
            panelLayer.SuspendLayout();
            PanelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            panel1.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconHome).BeginInit();
            PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLayer
            // 
            panelLayer.BackColor = Color.FromArgb(31, 58, 147);
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
            Ajuste.IconChar = IconChar.Cog;
            Ajuste.IconColor = Color.White;
            Ajuste.IconFont = IconFont.Auto;
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
            Asignación.IconChar = IconChar.ThumbTack;
            Asignación.IconColor = Color.White;
            Asignación.IconFont = IconFont.Auto;
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
            Rutas.IconChar = IconChar.Route;
            Rutas.IconColor = Color.White;
            Rutas.IconFont = IconFont.Auto;
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
            Autobuses.IconChar = IconChar.Bus;
            Autobuses.IconColor = Color.White;
            Autobuses.IconFont = IconFont.Auto;
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
            Choferes.IconChar = IconChar.DriversLicense;
            Choferes.IconColor = Color.White;
            Choferes.IconFont = IconFont.Auto;
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
            Dashboard.IconChar = IconChar.Cube;
            Dashboard.IconColor = Color.White;
            Dashboard.IconFont = IconFont.Auto;
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
            BtnHome.BackColor = Color.FromArgb(31, 58, 147);
            BtnHome.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHome.Cursor = Cursors.Hand;
            BtnHome.ForeColor = Color.FromArgb(24, 161, 251);
            BtnHome.IconChar = IconChar.Bus;
            BtnHome.IconColor = Color.FromArgb(24, 161, 251);
            BtnHome.IconFont = IconFont.Auto;
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
            panel1.BackColor = Color.FromArgb(31, 58, 147);
            panel1.Controls.Add(panelUser);
            panel1.Controls.Add(BtnMini);
            panel1.Controls.Add(BtnBig);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(LblHome);
            panel1.Controls.Add(IconHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 80);
            panel1.TabIndex = 0;
            panel1.MouseDown += FormMainHome_MouseDown;
            // 
            // panelUser
            // 
            panelUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelUser.BackColor = Color.FromArgb(31, 58, 147);
            panelUser.Controls.Add(lblUserRole);
            panelUser.Controls.Add(lblUserName);
            panelUser.Controls.Add(iconUser);
            panelUser.Cursor = Cursors.Hand;
            panelUser.Location = new Point(850, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(290, 80);
            panelUser.TabIndex = 6;
            panelUser.MouseLeave += panelUser_MouseLeave;
            panelUser.Click += panelUser_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(24, 161, 251);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = IconChar.RightFromBracket;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = IconFont.Auto;
            btnLogout.IconSize = 20;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(1070, 80);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(290, 40);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.TextAlign = ContentAlignment.MiddleCenter;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            btnLogout.Visible = false;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Segoe UI", 8F);
            lblUserRole.ForeColor = Color.FromArgb(200, 210, 255);
            lblUserRole.Location = new Point(70, 45);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(40, 19);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Admin";
            lblUserName.MouseEnter += panelUser_MouseEnter;
            lblUserName.MouseLeave += panelUser_MouseLeave;
            lblUserRole.Click += panelUser_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(70, 20);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(127, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Nombre Usuario";
            lblUserName.MouseEnter += panelUser_MouseEnter;
            lblUserName.MouseLeave += panelUser_MouseLeave;
            lblUserName.Click += panelUser_Click;
            // 
            // iconUser
            // 
            iconUser.BackColor = Color.FromArgb(31, 58, 147);
            iconUser.IconChar = IconChar.UserCircle;
            iconUser.IconColor = Color.FromArgb(24, 161, 251);
            iconUser.IconFont = IconFont.Auto;
            iconUser.IconSize = 50;
            iconUser.Location = new Point(10, 15);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(50, 50);
            iconUser.TabIndex = 0;
            iconUser.TabStop = false;
            iconUser.MouseEnter += panelUser_MouseEnter;
            iconUser.MouseLeave += panelUser_MouseLeave;
            iconUser.Click += panelUser_Click;
            // 
            // BtnMini
            // 
            BtnMini.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMini.BackColor = Color.FromArgb(31, 58, 147);
            BtnMini.Cursor = Cursors.Hand;
            BtnMini.FlatAppearance.BorderSize = 0;
            BtnMini.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 45, 120);
            BtnMini.FlatStyle = FlatStyle.Flat;
            BtnMini.IconChar = IconChar.WindowMinimize;
            BtnMini.IconColor = Color.White;
            BtnMini.IconFont = IconFont.Auto;
            BtnMini.IconSize = 20;
            BtnMini.Location = new Point(1188, 0);
            BtnMini.Name = "BtnMini";
            BtnMini.Size = new Size(40, 35);
            BtnMini.TabIndex = 5;
            BtnMini.UseVisualStyleBackColor = false;
            BtnMini.Click += BtnMini_Click;
            // 
            // BtnBig
            // 
            BtnBig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBig.BackColor = Color.FromArgb(31, 58, 147);
            BtnBig.Cursor = Cursors.Hand;
            BtnBig.FlatAppearance.BorderSize = 0;
            BtnBig.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 45, 120);
            BtnBig.FlatStyle = FlatStyle.Flat;
            BtnBig.IconChar = IconChar.WindowMaximize;
            BtnBig.IconColor = Color.White;
            BtnBig.IconFont = IconFont.Auto;
            BtnBig.IconSize = 20;
            BtnBig.Location = new Point(1234, 0);
            BtnBig.Name = "BtnBig";
            BtnBig.Size = new Size(40, 35);
            BtnBig.TabIndex = 4;
            BtnBig.UseVisualStyleBackColor = false;
            BtnBig.Click += BtnBig_Click;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnExit.BackColor = Color.FromArgb(31, 58, 147);
            BtnExit.Cursor = Cursors.Hand;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.IconChar = IconChar.Close;
            BtnExit.IconColor = Color.White;
            BtnExit.IconFont = IconFont.Auto;
            BtnExit.IconSize = 20;
            BtnExit.Location = new Point(1280, 0);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(40, 35);
            BtnExit.TabIndex = 3;
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
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
            IconHome.BackColor = Color.FromArgb(31, 58, 147);
            IconHome.IconChar = IconChar.House;
            IconHome.IconColor = Color.White;
            IconHome.IconFont = IconFont.Auto;
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
            iconPictureBox1.IconChar = IconChar.Bus;
            iconPictureBox1.IconColor = Color.FromArgb(24, 161, 251);
            iconPictureBox1.IconFont = IconFont.Auto;
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
            Controls.Add(btnLogout);
            Controls.Add(PanelDesktop);
            Controls.Add(panel1);
            Controls.Add(panelLayer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMainHome";
            Text = "FormMainHome";
            MouseDown += FormMainHome_MouseDown;
            panelLayer.ResumeLayout(false);
            PanelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconHome).EndInit();
            PanelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelLayer;
        private Panel PanelImage;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private IconButton Dashboard;
        private IconButton Ajuste;
        private IconButton Asignación;
        private IconButton Rutas;
        private IconButton Autobuses;
        private IconButton Choferes;
        private IconPictureBox BtnHome;
        private Panel panel1;
        private IconPictureBox IconHome;
        private Label LblHome;
        private Panel PanelDesktop;
        private IconPictureBox iconPictureBox1;
        private IconButton BtnExit;
        private IconButton BtnMini;
        private IconButton BtnBig;
        private Panel panelUser;
        private IconPictureBox iconUser;
        private Label lblUserName;
        private Label lblUserRole;
        private IconButton btnLogout;
    }
}