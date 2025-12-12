using Azure.Core;
using ControlDeAutoBus.Controller;
using ControlDeAutoBus.Core;
using ControlDeAutoBus.Domain.Response;
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
        private BusResponse _bus;

        // Constructor para registrar
        public FormBus()
        {
            InitializeComponent();
        }

        // Constructor para editar
        public FormBus(BusResponse bus)
        {
            InitializeComponent();
            _bus = bus;
            LoadBusData();
        }
        public void btnCancelar_Click(object sender, EventArgs e)
        {
            Navigator.GoToBuses();
        }
        private void LoadBusData()
        {
            if (_bus == null) return;

            txtMarca.Text = _bus.Brand;
            txtModel.Text = _bus.Model;
            txtPlaca.Text = _bus.LicensePlate;
            txtColor.Text = _bus.Color;
            dtpYear.Value = new DateTime(_bus.Year, 1, 1);

            btnRegistrar.Text = "Editar";
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            var busRequest = new Domain.Request.BusRequest
            {
                Id = _bus?.Id ?? 0,
                Brand = txtMarca.Text,
                Model = txtModel.Text,
                LicensePlate = txtPlaca.Text,
                Color = txtColor.Text,
                Year = dtpYear.Value.Year
            };
            _busController.AddOrUpdateBus(busRequest);

            MessageBox.Show(
                _bus == null
                    ? "Autobús registrado con éxito"
                    : "Autobús actualizado con éxito",
                "Operación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            Navigator.GoToBuses();
        }
    }
}
