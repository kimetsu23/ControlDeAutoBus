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

namespace ControlDeAutoBus.View.Drivers
{
    public partial class FormDrivers : Form
    {
        private readonly FormMainHome _mainForm;
        private ChoferesController _choferesController => AppServices.ChoferesController;
        private ChoferesResponse _chofer;
        public FormDrivers(FormMainHome mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

        }

        public FormDrivers(ChoferesResponse choferes)
        {
            InitializeComponent();
            _chofer = choferes;
            LoadDriverData();
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            Navegator.GoTo(new Table(_mainForm));
        }

        private void LoadDriverData()
        {
            if (_chofer == null) return;

            txtNombre.Text = _chofer.Name;
            txtApellido.Text = _chofer.LastName;
            txtCedula.Text = _chofer.IdCard;
            dtpFechaNacimiento.Value = _chofer.DataOfBirth;

            btnRegistrar.Text = "Editar";
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            var choferRequest = new Domain.Request.ChoferesRequest
            {
                Id = _chofer?.Id ?? 0,
                Name = txtNombre.Text,
                LastName = txtApellido.Text,
                DataOfBirth = dtpFechaNacimiento.Value,
                IdCard = txtCedula.Text
            };
            _choferesController.AddOrUpdateChoferes(choferRequest);
            MessageBox.Show(
                _chofer == null
                    ? "Chofer registrado con éxito"
                    : "Chofer actualizado con éxito",
                "Operación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

            Navegator.GoTo(new Table(_mainForm));

        }
    }
}
