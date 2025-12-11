using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeAutoBus.View.Drivers
{
    public partial class Table : Form
    {
        private readonly FormMainHome _mainForm;
        public Table(FormMainHome mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        // Eventos del TextBox de búsqueda
        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Buscar...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Buscar...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        // Evento Load del formulario
        private void Table_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadSampleData();
            txtSearch.ForeColor = Color.Gray;
        }

        private void ConfigureDataGridView()
        {
            // Estilo del header
            tableGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            tableGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(73, 80, 87);
            tableGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tableGrid.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);
            tableGrid.ColumnHeadersHeight = 45;

            // Estilo de las celdas
            tableGrid.DefaultCellStyle.BackColor = Color.White;
            tableGrid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            tableGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 235, 250);
            tableGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 58, 147);
            tableGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            tableGrid.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            tableGrid.RowTemplate.Height = 50;

            // Alternancia de colores
            tableGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 253);
        }

        private void LoadSampleData()
        {
            // Agregar columnas
            tableGrid.Columns.Add("ID", "ID");
            tableGrid.Columns.Add("Nombre", "Nombre");
            tableGrid.Columns.Add("Apellido", "Apellido");
            tableGrid.Columns.Add("Fecha de Nacimiento", "Fecha de Nacimiento");
            tableGrid.Columns.Add("Cedula", "Cedula");
            tableGrid.Columns.Add("Usuario", "Usuario");

            // Ajustar anchos
            tableGrid.Columns["ID"].Width = 60;
            tableGrid.Columns["Nombre"].Width = 200;
            tableGrid.Columns["Fecha de Nacimiento"].Width = 100;

            // Datos de ejemplo (puedes comentar esto si no tienes datos aún)
            /*
            tableGrid.Rows.Add("001", "Problema de red", "Juan Pérez", "2024-12-10", "Sí", "Infraestructura", "Alta", "Alto", "Urgente", "Tech1");
            tableGrid.Rows.Add("002", "Actualización software", "María López", "2024-12-11", "No", "Software", "Media", "Medio", "Normal", "Tech2");
            */

            lblShowing.Text = $"Mostrando 0 a 0 de 0 entradas";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new FormDrivers(_mainForm));

        }
    }
}
