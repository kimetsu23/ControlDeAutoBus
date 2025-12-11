namespace ControlDeAutoBus.View.Settings
{
    partial class FormSettings
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
        private Panel panelMain;
        private Label lblTitle;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblUsuario;
        private TextBox txtUsuario;
        //private DateTimePicker dtpFechaNacimiento;
        private Label lblRol;
        private TextBox txtRol;
        private Button btnRegistrar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblTitle = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblRol = new Label();
            txtRol = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lblClave = new Label();
            txtClave = new TextBox();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblClave);
            panelMain.Controls.Add(txtClave);
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblNombre);
            panelMain.Controls.Add(txtNombre);
            panelMain.Controls.Add(lblApellido);
            panelMain.Controls.Add(txtApellido);
            panelMain.Controls.Add(lblUsuario);
            panelMain.Controls.Add(txtUsuario);
            panelMain.Controls.Add(lblRol);
            panelMain.Controls.Add(txtRol);
            panelMain.Controls.Add(btnRegistrar);
            panelMain.Controls.Add(btnCancelar);
            panelMain.Location = new Point(30, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(440, 580);
            panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 58, 147);
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registrar Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.FromArgb(73, 80, 87);
            lblNombre.Location = new Point(30, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(30, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(380, 30);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F);
            lblApellido.ForeColor = Color.FromArgb(73, 80, 87);
            lblApellido.Location = new Point(30, 170);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 23);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(30, 196);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(380, 30);
            txtApellido.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(73, 80, 87);
            lblUsuario.Location = new Point(30, 240);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(160, 23);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Nombre de Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(30, 266);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(380, 30);
            txtUsuario.TabIndex = 8;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.ForeColor = Color.FromArgb(73, 80, 87);
            lblRol.Location = new Point(30, 310);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 23);
            lblRol.TabIndex = 7;
            lblRol.Text = "Rol";
            // 
            // txtRol
            // 
            txtRol.BackColor = Color.White;
            txtRol.BorderStyle = BorderStyle.FixedSingle;
            txtRol.Font = new Font("Segoe UI", 10F);
            txtRol.Location = new Point(30, 336);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(380, 30);
            txtRol.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(31, 58, 147);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 45, 120);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(30, 464);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(180, 45);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(220, 223, 230);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 249, 250);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(73, 80, 87);
            btnCancelar.Location = new Point(230, 464);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10F);
            lblClave.ForeColor = Color.FromArgb(73, 80, 87);
            lblClave.Location = new Point(30, 383);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(97, 23);
            lblClave.TabIndex = 11;
            lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.Location = new Point(30, 409);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(380, 30);
            txtClave.TabIndex = 12;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(829, 721);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Chofer";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblClave;
        private TextBox txtClave;
    }
}