using FontAwesome.Sharp;

namespace ControlDeAutoBus.View
{
    partial class FormLogin
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
            panelTitleBar = new Panel();
            btnMinimizar = new IconButton();
            btnCerrar = new IconButton();
            btnMaximizar = new IconButton();
            panelLeft = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            iconBus = new IconPictureBox();
            panelRight = new Panel();
            IconEye = new IconPictureBox();
            linkForgotPassword = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            panelPassword = new Panel();
            iconPassword = new IconPictureBox();
            txtUsuario = new TextBox();
            panelUsuario = new Panel();
            iconUser = new IconPictureBox();
            lblTitle = new Label();
            panelTitleBar.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBus).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconEye).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPassword).BeginInit();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(31, 58, 147);
            panelTitleBar.Controls.Add(btnMinimizar);
            panelTitleBar.Controls.Add(btnCerrar);
            panelTitleBar.Controls.Add(btnMaximizar);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(900, 35);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.FromArgb(31, 58, 147);
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 45, 120);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.IconChar = IconChar.WindowMinimize;
            btnMinimizar.IconColor = Color.White;
            btnMinimizar.IconFont = IconFont.Auto;
            btnMinimizar.IconSize = 20;
            btnMinimizar.Location = new Point(780, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 35);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(31, 58, 147);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.IconChar = IconChar.Close;
            btnCerrar.IconColor = Color.White;
            btnCerrar.IconFont = IconFont.Auto;
            btnCerrar.IconSize = 20;
            btnCerrar.Location = new Point(860, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 35);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.FromArgb(31, 58, 147);
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 45, 120);
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.IconChar = IconChar.WindowMaximize;
            btnMaximizar.IconColor = Color.White;
            btnMaximizar.IconFont = IconFont.Auto;
            btnMaximizar.IconSize = 20;
            btnMaximizar.Location = new Point(820, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(40, 35);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(31, 58, 147);
            panelLeft.Controls.Add(lblWelcome);
            panelLeft.Controls.Add(lblSubtitle);
            panelLeft.Controls.Add(iconBus);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 35);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(400, 515);
            panelLeft.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.None;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(50, 300);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(260, 54);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "¡Bienvenido!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.None;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 210, 255);
            lblSubtitle.Location = new Point(50, 360);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(300, 80);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sistema de Control de Autobuses\r\nGestión eficiente de rutas y asignaciones";
            // 
            // iconBus
            // 
            iconBus.Anchor = AnchorStyles.None;
            iconBus.BackColor = Color.FromArgb(31, 58, 147);
            iconBus.ForeColor = Color.FromArgb(24, 161, 251);
            iconBus.IconChar = IconChar.Bus;
            iconBus.IconColor = Color.FromArgb(24, 161, 251);
            iconBus.IconFont = IconFont.Auto;
            iconBus.IconSize = 180;
            iconBus.Location = new Point(110, 100);
            iconBus.Name = "iconBus";
            iconBus.Size = new Size(180, 180);
            iconBus.TabIndex = 2;
            iconBus.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.Anchor = AnchorStyles.None;
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(IconEye);
            panelRight.Controls.Add(linkForgotPassword);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(txtPassword);
            panelRight.Controls.Add(panelPassword);
            panelRight.Controls.Add(txtUsuario);
            panelRight.Controls.Add(panelUsuario);
            panelRight.Controls.Add(lblTitle);
            panelRight.Location = new Point(400, 35);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(500, 515);
            panelRight.TabIndex = 2;
            // 
            // IconEye
            // 
            IconEye.BackColor = Color.White;
            IconEye.Cursor = Cursors.Hand;
            IconEye.ForeColor = Color.FromArgb(108, 117, 125);
            IconEye.IconChar = IconChar.Eye;
            IconEye.IconColor = Color.FromArgb(108, 117, 125);
            IconEye.IconFont = IconFont.Auto;
            IconEye.IconSize = 24;
            IconEye.Location = new Point(390, 269);
            IconEye.Name = "IconEye";
            IconEye.Size = new Size(24, 24);
            IconEye.TabIndex = 7;
            IconEye.TabStop = false;
            IconEye.Click += BtnVerPassword_Click;
            IconEye.MouseEnter += IconEye_MouseEnter;
            IconEye.MouseLeave += IconEye_MouseLeave;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.ActiveLinkColor = Color.FromArgb(25, 45, 120);
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Font = new Font("Segoe UI", 9F);
            linkForgotPassword.LinkColor = Color.FromArgb(31, 58, 147);
            linkForgotPassword.Location = new Point(60, 320);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(161, 20);
            linkForgotPassword.TabIndex = 6;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "¿Olvidó su contraseña?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(31, 58, 147);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 45, 120);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(380, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "INICIAR SESIÓN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(100, 265);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 25);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.FromArgb(230, 230, 230);
            panelPassword.Controls.Add(iconPassword);
            panelPassword.Location = new Point(60, 255);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(380, 45);
            panelPassword.TabIndex = 3;
            // 
            // iconPassword
            // 
            iconPassword.BackColor = Color.FromArgb(230, 230, 230);
            iconPassword.ForeColor = Color.FromArgb(108, 117, 125);
            iconPassword.IconChar = IconChar.Lock;
            iconPassword.IconColor = Color.FromArgb(108, 117, 125);
            iconPassword.IconFont = IconFont.Auto;
            iconPassword.IconSize = 24;
            iconPassword.Location = new Point(15, 10);
            iconPassword.Name = "iconPassword";
            iconPassword.Size = new Size(24, 24);
            iconPassword.TabIndex = 0;
            iconPassword.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(100, 185);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(320, 25);
            txtUsuario.TabIndex = 2;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(230, 230, 230);
            panelUsuario.Controls.Add(iconUser);
            panelUsuario.Location = new Point(60, 175);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(380, 45);
            panelUsuario.TabIndex = 1;
            // 
            // iconUser
            // 
            iconUser.BackColor = Color.FromArgb(230, 230, 230);
            iconUser.ForeColor = Color.FromArgb(108, 117, 125);
            iconUser.IconChar = IconChar.User;
            iconUser.IconColor = Color.FromArgb(108, 117, 125);
            iconUser.IconFont = IconFont.Auto;
            iconUser.IconSize = 24;
            iconUser.Location = new Point(15, 10);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(24, 24);
            iconUser.TabIndex = 0;
            iconUser.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 58, 147);
            lblTitle.Location = new Point(60, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Iniciar Sesión";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Control de Autobuses";
            panelTitleBar.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBus).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconEye).EndInit();
            panelPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPassword).EndInit();
            panelUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private IconButton btnCerrar;
        private IconButton btnMinimizar;
        private IconButton btnMaximizar;
        private Panel panelLeft;
        private Label lblWelcome;
        private Label lblSubtitle;
        private IconPictureBox iconBus;
        private Panel panelRight;
        private Label lblTitle;
        private Panel panelUsuario;
        private IconPictureBox iconUser;
        private TextBox txtUsuario;
        private Panel panelPassword;
        private IconPictureBox iconPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkForgotPassword;
        private IconPictureBox IconEye;
    }
}