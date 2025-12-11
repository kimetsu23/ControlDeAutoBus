using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlDeAutoBus.View.Drivers
{
    partial class FormDrivers
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
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblCedula;
        private TextBox txtCedula;
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
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblCedula = new Label();
            txtCedula = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblNombre);
            panelMain.Controls.Add(txtNombre);
            panelMain.Controls.Add(lblApellido);
            panelMain.Controls.Add(txtApellido);
            panelMain.Controls.Add(lblFechaNacimiento);
            panelMain.Controls.Add(dtpFechaNacimiento);
            panelMain.Controls.Add(lblCedula);
            panelMain.Controls.Add(txtCedula);
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
            lblTitle.Size = new Size(311, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registro de Choferes";
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
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10F);
            lblFechaNacimiento.ForeColor = Color.FromArgb(73, 80, 87);
            lblFechaNacimiento.Location = new Point(30, 240);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(171, 23);
            lblFechaNacimiento.TabIndex = 5;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CalendarFont = new Font("Segoe UI", 10F);
            dtpFechaNacimiento.Font = new Font("Segoe UI", 10F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(30, 266);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(380, 30);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 10F);
            lblCedula.ForeColor = Color.FromArgb(73, 80, 87);
            lblCedula.Location = new Point(30, 310);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(63, 23);
            lblCedula.TabIndex = 7;
            lblCedula.Text = "Cédula";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.White;
            txtCedula.BorderStyle = BorderStyle.FixedSingle;
            txtCedula.Font = new Font("Segoe UI", 10F);
            txtCedula.Location = new Point(30, 336);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(380, 30);
            txtCedula.TabIndex = 8;
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
            // FormDrivers
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
            Name = "FormDrivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Chofer";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}