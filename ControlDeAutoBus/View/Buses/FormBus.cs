using ControlDeAutoBus.Controller;
using ControlDeAutoBus.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeAutoBus.View.Buses
{
    public partial class FormBus : Form
    {
        private BusController _busController => AppServices.BusController;
        public FormBus( )
        {
            InitializeComponent();

        }
        public void btnCancelar_Click(object sender, EventArgs e)
        {
            Navegator.GoToBuses();
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            var busRequest = new Domain.Request.BusRequest
            {
                Brand = txtMarca.Text,
                Model = txtModel.Text,
                LicensePlate = txtPlaca.Text,
                Color = txtColor.Text,
                Year = dtpYear.Value.Year
            };
            _busController.AddOrUpdateBus(busRequest);

            MessageBox.Show("Autobus registrado con exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Navegator.GoToBuses();

        }
    }
}
