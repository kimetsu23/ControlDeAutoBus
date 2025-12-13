using ControlDeAutoBus.Controller;
using ControlDeAutoBus.Core;
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
        private ChoferesController _choferesController => AppServices.ChoferesController;
        public Table(FormMainHome mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            tableGrid.CellClick += tableGrid_CellClick;
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
            var data = _choferesController.GetAllChoferes();
            // Agregar columnas
            tableGrid.Columns.Add("ID", "ID");
            tableGrid.Columns.Add("Nombre", "Nombre");
            tableGrid.Columns.Add("Apellido", "Apellido");
            tableGrid.Columns.Add("Fecha de Nacimiento", "Fecha de Nacimiento");
            tableGrid.Columns.Add("Cedula", "Cedula");

            // Ajustar anchos
            tableGrid.Columns["ID"].Width = 60;
            tableGrid.Columns["Nombre"].Width = 200;
            tableGrid.Columns["Apellido"].Width = 100;

            if (!tableGrid.Columns.Contains("Acciones"))
            {
                tableGrid.Columns.Add(new ActionsButtonsColumn { Name = "Acciones" });
            }

            // Datos de ejemplo (puedes comentar esto si no tienes datos aún)
            tableGrid.Rows.Clear();

            foreach (var driver in data)
            {
                tableGrid.Rows.Add(driver.Id, driver.Name, driver.LastName, driver.IdCard, driver.DataOfBirth);
            }

            lblShowing.Text = $"Mostrando 0 a 0 de 0 entradas";
        }

        private void tableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || tableGrid.Columns[e.ColumnIndex].Name != "Acciones")
                return;

            var cellBounds = tableGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

            int mouseX = tableGrid.PointToClient(Cursor.Position).X - cellBounds.X;

            int buttonWidth = (cellBounds.Width - 15) / 2;

            int Id = Convert.ToInt32(tableGrid.Rows[e.RowIndex].Cells["ID"].Value);

            // CLICK EN EDITAR
            if (mouseX < buttonWidth)
            {
                var bus = _choferesController.GetChoferesById(Id);

                Navigator.GoTo(new FormDrivers(bus));

                return;
            }


            // CLICK EN ELIMINAR
            DialogResult result = MessageBox.Show(
                "¿Seguro que quieres eliminar este autobús?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _choferesController.DeleteChoferes(Id);
                tableGrid.Rows.RemoveAt(e.RowIndex);
            }
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
            Navigator.GoTo(new FormDrivers(_mainForm));

        }
    }
}
