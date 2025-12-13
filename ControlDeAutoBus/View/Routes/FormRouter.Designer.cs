namespace ControlDeAutoBus.View.Routes
{
    partial class FormRouter
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
        private Label lblNombreRuta;
        private TextBox txtNombreRuta;
        private Button btnRegistrar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblTitle = new Label();
            lblNombreRuta = new Label();
            txtNombreRuta = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblNombreRuta);
            panelMain.Controls.Add(txtNombreRuta);
            panelMain.Controls.Add(btnRegistrar);
            panelMain.Controls.Add(btnCancelar);
            panelMain.Location = new Point(30, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(440, 368);
            panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 58, 147);
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(304, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Módulo de Choferes";
            // 
            // lblNombreRuta
            // 
            lblNombreRuta.AutoSize = true;
            lblNombreRuta.Font = new Font("Segoe UI", 10F);
            lblNombreRuta.ForeColor = Color.FromArgb(73, 80, 87);
            lblNombreRuta.Location = new Point(30, 131);
            lblNombreRuta.Name = "lblNombreRuta";
            lblNombreRuta.Size = new Size(137, 23);
            lblNombreRuta.TabIndex = 1;
            lblNombreRuta.Text = "Nombre de Ruta";
            // 
            // txtNombreRuta
            // 
            txtNombreRuta.BackColor = Color.White;
            txtNombreRuta.BorderStyle = BorderStyle.FixedSingle;
            txtNombreRuta.Font = new Font("Segoe UI", 10F);
            txtNombreRuta.Location = new Point(30, 157);
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.Size = new Size(380, 30);
            txtNombreRuta.TabIndex = 2;
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
            btnRegistrar.Location = new Point(30, 263);
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
            btnCancelar.Location = new Point(230, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRouter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(572, 593);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRouter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Chofer";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}