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

namespace ControlDeAutoBus.View.Drivers
{
    public partial class FormDrivers : Form
    {
        private readonly FormMainHome _mainForm;
        private ChoferesController _choferesController => AppServices.ChoferesController;
        public FormDrivers(FormMainHome mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new Table(_mainForm));
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            var choferRequest = new Domain.Request.ChoferesRequest
            {
                Name = txtNombre.Text,
                LastName = txtApellido.Text,
                DataOfBirth = dtpFechaNacimiento.Value,
                IdCard = txtCedula.Text
            };
            _choferesController.AddOrUpdateChoferes(choferRequest);
            MessageBox.Show("Chofer registrado con exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.OpenChildForm(new Table(_mainForm));

        }
    }
}
