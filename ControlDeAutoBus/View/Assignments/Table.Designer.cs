namespace ControlDeAutoBus.View.Assignments
{
    partial class Table
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
        private Panel panelContainer;
        private Panel panelHeader;
        private Panel panelToolbar;
        private Button btnRegistrar;
        private Label labelTitle;
        private Label labelHome;
        private Label labelArrow;
        private Label labelBread;
        private DataGridView tableGrid;
        private TextBox txtSearch;
        private Button btnCopy;
        private Button btnCSV;
        private Button btnExcel;
        private Button btnPDF;
        private Button btnPrint;
        private Label lblShowing;
        private Button btnPrevious;
        private Button btnNext;

        private void InitializeComponent()
        {
            panelContainer = new Panel();
            panelHeader = new Panel();
            btnRegistrar = new Button();
            panelToolbar = new Panel();
            btnCopy = new Button();
            btnCSV = new Button();
            btnExcel = new Button();
            btnPDF = new Button();
            btnPrint = new Button();
            txtSearch = new TextBox();
            tableGrid = new DataGridView();
            lblShowing = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            labelTitle = new Label();
            labelHome = new Label();
            labelArrow = new Label();
            labelBread = new Label();
            panelContainer.SuspendLayout();
            panelHeader.SuspendLayout();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableGrid).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.None;
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(panelHeader);
            panelContainer.Controls.Add(panelToolbar);
            panelContainer.Controls.Add(tableGrid);
            panelContainer.Controls.Add(lblShowing);
            panelContainer.Controls.Add(btnPrevious);
            panelContainer.Controls.Add(btnNext);
            panelContainer.Location = new Point(40, 80);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1320, 600);
            panelContainer.TabIndex = 4;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnRegistrar);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(25, 15, 25, 15);
            panelHeader.Size = new Size(1320, 70);
            panelHeader.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSize = true;
            btnRegistrar.BackColor = Color.FromArgb(31, 58, 147);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 45, 120);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(1104, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(201, 40);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar Asignaciones";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.White;
            panelToolbar.Controls.Add(btnCopy);
            panelToolbar.Controls.Add(btnCSV);
            panelToolbar.Controls.Add(btnExcel);
            panelToolbar.Controls.Add(btnPDF);
            panelToolbar.Controls.Add(btnPrint);
            panelToolbar.Controls.Add(txtSearch);
            panelToolbar.Location = new Point(0, 70);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(25, 10, 25, 10);
            panelToolbar.Size = new Size(1320, 60);
            panelToolbar.TabIndex = 1;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.White;
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.FlatAppearance.BorderColor = Color.FromArgb(31, 58, 147);
            btnCopy.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 250);
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopy.ForeColor = Color.FromArgb(31, 58, 147);
            btnCopy.Location = new Point(25, 15);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(70, 32);
            btnCopy.TabIndex = 0;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = false;
            // 
            // btnCSV
            // 
            btnCSV.BackColor = Color.White;
            btnCSV.Cursor = Cursors.Hand;
            btnCSV.FlatAppearance.BorderColor = Color.FromArgb(31, 58, 147);
            btnCSV.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 250);
            btnCSV.FlatStyle = FlatStyle.Flat;
            btnCSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCSV.ForeColor = Color.FromArgb(31, 58, 147);
            btnCSV.Location = new Point(110, 15);
            btnCSV.Name = "btnCSV";
            btnCSV.Size = new Size(70, 32);
            btnCSV.TabIndex = 1;
            btnCSV.Text = "CSV";
            btnCSV.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.White;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatAppearance.BorderColor = Color.FromArgb(31, 58, 147);
            btnExcel.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 250);
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcel.ForeColor = Color.FromArgb(31, 58, 147);
            btnExcel.Location = new Point(180, 15);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(70, 32);
            btnExcel.TabIndex = 2;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.White;
            btnPDF.Cursor = Cursors.Hand;
            btnPDF.FlatAppearance.BorderColor = Color.FromArgb(31, 58, 147);
            btnPDF.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 250);
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPDF.ForeColor = Color.FromArgb(31, 58, 147);
            btnPDF.Location = new Point(260, 15);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(70, 32);
            btnPDF.TabIndex = 3;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderColor = Color.FromArgb(31, 58, 147);
            btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 242, 250);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.FromArgb(31, 58, 147);
            btnPrint.Location = new Point(330, 15);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(70, 32);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(1050, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 30);
            txtSearch.TabIndex = 5;
            txtSearch.Text = "Buscar...";
            txtSearch.GotFocus += txtSearch_GotFocus;
            txtSearch.LostFocus += txtSearch_LostFocus;
            // 
            // tableGrid
            // 
            tableGrid.AllowUserToAddRows = false;
            tableGrid.AllowUserToDeleteRows = false;
            tableGrid.AllowUserToResizeRows = false;
            tableGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableGrid.BackgroundColor = Color.White;
            tableGrid.BorderStyle = BorderStyle.None;
            tableGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableGrid.EnableHeadersVisualStyles = false;
            tableGrid.GridColor = Color.FromArgb(230, 230, 230);
            tableGrid.Location = new Point(25, 145);
            tableGrid.Name = "tableGrid";
            tableGrid.ReadOnly = true;
            tableGrid.RowHeadersVisible = false;
            tableGrid.RowHeadersWidth = 51;
            tableGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableGrid.Size = new Size(1270, 380);
            tableGrid.TabIndex = 2;
            // 
            // lblShowing
            // 
            lblShowing.AutoSize = true;
            lblShowing.Font = new Font("Segoe UI", 9F);
            lblShowing.ForeColor = Color.Gray;
            lblShowing.Location = new Point(25, 545);
            lblShowing.Name = "lblShowing";
            lblShowing.Size = new Size(211, 20);
            lblShowing.TabIndex = 3;
            lblShowing.Text = "Mostrando 0 a 0 de 0 entradas";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.White;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(220, 223, 230);
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 9F);
            btnPrevious.ForeColor = Color.Gray;
            btnPrevious.Location = new Point(1050, 540);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(100, 35);
            btnPrevious.TabIndex = 4;
            btnPrevious.Text = "Anterior";
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(220, 223, 230);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = Color.Gray;
            btnNext.Location = new Point(1180, 540);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 35);
            btnNext.TabIndex = 5;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(33, 37, 41);
            labelTitle.Location = new Point(40, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(402, 46);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Listado de Asignaciones";
            // 
            // labelHome
            // 
            labelHome.Anchor = AnchorStyles.None;
            labelHome.AutoSize = true;
            labelHome.Cursor = Cursors.Hand;
            labelHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelHome.ForeColor = Color.FromArgb(31, 58, 147);
            labelHome.Location = new Point(1132, 30);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(58, 23);
            labelHome.TabIndex = 0;
            labelHome.Text = "Home";
            // 
            // labelArrow
            // 
            labelArrow.Anchor = AnchorStyles.None;
            labelArrow.AutoSize = true;
            labelArrow.Font = new Font("Segoe UI", 10F);
            labelArrow.ForeColor = Color.Gray;
            labelArrow.Location = new Point(1195, 30);
            labelArrow.Name = "labelArrow";
            labelArrow.Size = new Size(19, 23);
            labelArrow.TabIndex = 1;
            labelArrow.Text = "»";
            // 
            // labelBread
            // 
            labelBread.Anchor = AnchorStyles.None;
            labelBread.AutoSize = true;
            labelBread.Font = new Font("Segoe UI", 10F);
            labelBread.ForeColor = Color.Gray;
            labelBread.Location = new Point(1215, 30);
            labelBread.Name = "labelBread";
            labelBread.Size = new Size(192, 23);
            labelBread.TabIndex = 2;
            labelBread.Text = "Listado de Asignaciones";
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1400, 750);
            Controls.Add(panelContainer);
            Controls.Add(labelTitle);
            Controls.Add(labelBread);
            Controls.Add(labelArrow);
            Controls.Add(labelHome);
            Font = new Font("Segoe UI", 9F);
            Name = "Table";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Asignaciones";
            Load += Table_Load;
            MouseDown += Table_MouseDown;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

    }
}