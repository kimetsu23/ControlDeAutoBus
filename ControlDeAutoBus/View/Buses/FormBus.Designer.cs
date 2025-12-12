namespace ControlDeAutoBus.View.Buses
{
    partial class FormBus
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
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblModelo;
        private TextBox txtModel;
        private Label lblYear;
        private DateTimePicker dtpYear;
        private Label lblColor;
        private TextBox txtColor;
        private Button btnRegistrar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblPlaca = new Label();
            txtPlaca = new TextBox();
            lblTitle = new Label();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblModelo = new Label();
            txtModel = new TextBox();
            lblYear = new Label();
            dtpYear = new DateTimePicker();
            lblColor = new Label();
            txtColor = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblPlaca);
            panelMain.Controls.Add(txtPlaca);
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblMarca);
            panelMain.Controls.Add(txtMarca);
            panelMain.Controls.Add(lblModelo);
            panelMain.Controls.Add(txtModel);
            panelMain.Controls.Add(lblYear);
            panelMain.Controls.Add(dtpYear);
            panelMain.Controls.Add(lblColor);
            panelMain.Controls.Add(txtColor);
            panelMain.Controls.Add(btnRegistrar);
            panelMain.Controls.Add(btnCancelar);
            panelMain.Location = new Point(30, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(440, 551);
            panelMain.TabIndex = 0;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI", 10F);
            lblPlaca.ForeColor = Color.FromArgb(73, 80, 87);
            lblPlaca.Location = new Point(30, 242);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(50, 23);
            lblPlaca.TabIndex = 11;
            lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.White;
            txtPlaca.BorderStyle = BorderStyle.FixedSingle;
            txtPlaca.Font = new Font("Segoe UI", 10F);
            txtPlaca.Location = new Point(30, 268);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(380, 30);
            txtPlaca.TabIndex = 12;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 58, 147);
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registrar Autobus";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 10F);
            lblMarca.ForeColor = Color.FromArgb(73, 80, 87);
            lblMarca.Location = new Point(30, 100);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(57, 23);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.White;
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Font = new Font("Segoe UI", 10F);
            txtMarca.Location = new Point(30, 126);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(380, 30);
            txtMarca.TabIndex = 2;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 10F);
            lblModelo.ForeColor = Color.FromArgb(73, 80, 87);
            lblModelo.Location = new Point(30, 170);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(68, 23);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Modelo";
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.White;
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Font = new Font("Segoe UI", 10F);
            txtModel.Location = new Point(30, 196);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(380, 30);
            txtModel.TabIndex = 4;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 10F);
            lblYear.ForeColor = Color.FromArgb(73, 80, 87);
            lblYear.Location = new Point(30, 380);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(138, 23);
            lblYear.TabIndex = 5;
            lblYear.Text = "Año del Autobus";
            // 
            // dtpYear
            // 
            dtpYear.CalendarFont = new Font("Segoe UI", 10F);
            dtpYear.Font = new Font("Segoe UI", 10F);
            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;
            dtpYear.MinDate = new DateTime(1980, 1, 1);
            dtpYear.MaxDate = new DateTime(DateTime.Now.Year + 1, 12, 31);
            dtpYear.Location = new Point(30, 406);
            dtpYear.Name = "dtpYear";
            dtpYear.Size = new Size(380, 30);
            dtpYear.TabIndex = 6;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 10F);
            lblColor.ForeColor = Color.FromArgb(73, 80, 87);
            lblColor.Location = new Point(30, 310);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(51, 23);
            lblColor.TabIndex = 7;
            lblColor.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.White;
            txtColor.BorderStyle = BorderStyle.FixedSingle;
            txtColor.Font = new Font("Segoe UI", 10F);
            txtColor.Location = new Point(30, 336);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(380, 30);
            txtColor.TabIndex = 8;
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
            btnRegistrar.Location = new Point(30, 456);
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
            btnCancelar.Location = new Point(230, 456);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormBus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(729, 789);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de AutoBuses";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPlaca;
        private TextBox txtPlaca;
    }
}