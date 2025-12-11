namespace ControlDeAutoBus.View.Assignments
{
    partial class FormAssignments
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
        private Label lblChoferes;
        private Label lblAutobuses;
        private Label lblRuta;
        private Label lblActivo;
        private TextBox txtActivo;
        private Button btnRegistrar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblTitle = new Label();
            lblChoferes = new Label();
            lblAutobuses = new Label();
            lblRuta = new Label();
            lblActivo = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            dtpActivo = new ComboBox();
            dtpRuta = new ComboBox();
            dtpAutoBuses = new ComboBox();
            dtpChoferes = new ComboBox();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(dtpChoferes);
            panelMain.Controls.Add(dtpAutoBuses);
            panelMain.Controls.Add(dtpRuta);
            panelMain.Controls.Add(dtpActivo);
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblChoferes);
            panelMain.Controls.Add(lblAutobuses);
            panelMain.Controls.Add(lblRuta);
            panelMain.Controls.Add(lblActivo);
            panelMain.Controls.Add(btnRegistrar);
            panelMain.Controls.Add(btnCancelar);
            panelMain.Location = new Point(30, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(440, 520);
            panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 58, 147);
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(338, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registrar Asignaciones";
            // 
            // lblChoferes
            // 
            lblChoferes.AutoSize = true;
            lblChoferes.Font = new Font("Segoe UI", 10F);
            lblChoferes.ForeColor = Color.FromArgb(73, 80, 87);
            lblChoferes.Location = new Point(30, 100);
            lblChoferes.Name = "lblChoferes";
            lblChoferes.Size = new Size(77, 23);
            lblChoferes.TabIndex = 1;
            lblChoferes.Text = "Choferes";
            // 
            // lblAutobuses
            // 
            lblAutobuses.AutoSize = true;
            lblAutobuses.Font = new Font("Segoe UI", 10F);
            lblAutobuses.ForeColor = Color.FromArgb(73, 80, 87);
            lblAutobuses.Location = new Point(30, 170);
            lblAutobuses.Name = "lblAutobuses";
            lblAutobuses.Size = new Size(90, 23);
            lblAutobuses.TabIndex = 3;
            lblAutobuses.Text = "Autobuses";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI", 10F);
            lblRuta.ForeColor = Color.FromArgb(73, 80, 87);
            lblRuta.Location = new Point(30, 240);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(45, 23);
            lblRuta.TabIndex = 5;
            lblRuta.Text = "Ruta";
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Font = new Font("Segoe UI", 10F);
            lblActivo.ForeColor = Color.FromArgb(73, 80, 87);
            lblActivo.Location = new Point(30, 310);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(57, 23);
            lblActivo.TabIndex = 7;
            lblActivo.Text = "Activo";
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
            btnRegistrar.Location = new Point(30, 400);
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
            btnCancelar.Location = new Point(230, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpActivo
            // 
            dtpActivo.BackColor = Color.White;
            dtpActivo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpActivo.FormattingEnabled = true;
            dtpActivo.Location = new Point(30, 336);
            dtpActivo.Name = "dtpActivo";
            dtpActivo.Size = new Size(380, 31);
            dtpActivo.TabIndex = 8;
            // 
            // dtpRuta
            // 
            dtpRuta.BackColor = Color.White;
            dtpRuta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRuta.FormattingEnabled = true;
            dtpRuta.Location = new Point(30, 266);
            dtpRuta.Name = "dtpRuta";
            dtpRuta.Size = new Size(380, 31);
            dtpRuta.TabIndex = 11;
            // 
            // dtpAutoBuses
            // 
            dtpAutoBuses.BackColor = Color.White;
            dtpAutoBuses.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAutoBuses.FormattingEnabled = true;
            dtpAutoBuses.Location = new Point(30, 196);
            dtpAutoBuses.Name = "dtpAutoBuses";
            dtpAutoBuses.Size = new Size(380, 31);
            dtpAutoBuses.TabIndex = 12;
            // 
            // dtpChoferes
            // 
            dtpChoferes.BackColor = Color.White;
            dtpChoferes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpChoferes.FormattingEnabled = true;
            dtpChoferes.Location = new Point(30, 126);
            dtpChoferes.Name = "dtpChoferes";
            dtpChoferes.Size = new Size(380, 31);
            dtpChoferes.TabIndex = 13;
            // 
            // FormAssignments
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
            Name = "FormAssignments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Asignaciones";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox dtpActivo;
        private ComboBox dtpRuta;
        private ComboBox dtpChoferes;
        private ComboBox dtpAutoBuses;
    }
}