using ControlDeAutoBus.Controller;
using ControlDeAutoBus.Core;
using ControlDeAutoBus.Domain.Request;
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

namespace ControlDeAutoBus.View.Assignments
{
    public partial class FormAssignments : Form
    {
        private readonly FormMainHome _mainForm;
        private AsignacionController _asignacionController => AppServices.AsignacionController;
        private AsignacionResponse _asignacionResponse;
        public FormAssignments(FormMainHome mainHome)
        {
            InitializeComponent();
            _mainForm = mainHome;
            LoadComboBoxes();

        }

        public FormAssignments(AsignacionResponse asignacionResponse)
        {
            InitializeComponent();
            _asignacionResponse = asignacionResponse;
            LoadComboBoxes();
            LoadAssignmentData();
  
        }
        public void btnCancelar_Click(object sender, EventArgs e)
        {
            Navigator.GoTo(new Table(_mainForm));
        }
        private void LoadComboBoxes()
        {
            bool isEdit = _asignacionResponse != null;

            //CHOFERES
            dtpChoferes.DataSource = isEdit
                ? _asignacionController.GetChoferes(_asignacionResponse.Id)
                : _asignacionController.GetChoferes();

            dtpChoferes.DisplayMember = "Name";
            dtpChoferes.ValueMember = "Id";
            dtpChoferes.SelectedIndex = -1;

            //AUTOBUSES 
            dtpAutoBuses.DataSource = isEdit
                ? _asignacionController.GetAutobuses(_asignacionResponse.Id)
                : _asignacionController.GetAutobuses();

            dtpAutoBuses.DisplayMember = "MarcaModelo";
            dtpAutoBuses.ValueMember = "Id";
            dtpAutoBuses.SelectedIndex = -1;

            //RUTAS 
            dtpRuta.DataSource = isEdit
                ? _asignacionController.GetRutas(_asignacionResponse.Id)
                : _asignacionController.GetRutas();

            dtpRuta.DisplayMember = "NameRoute";
            dtpRuta.ValueMember = "Id";
            dtpRuta.SelectedIndex = -1;

            var estados = new List<KeyValuePair<string, bool>>()
            {
                new KeyValuePair<string, bool>("Sí", true),
                new KeyValuePair<string, bool>("No", false)
            };
            dtpActivo.DataSource = estados;
            dtpActivo.DisplayMember = "Key";
            dtpActivo.ValueMember = "Value";
            dtpActivo.SelectedIndex = -1;
        }

        public void LoadAssignmentData()
        {
            if (_asignacionResponse != null)
            {
                dtpChoferes.SelectedValue = _asignacionResponse.DriverId;
                dtpAutoBuses.SelectedValue = _asignacionResponse.BusId;
                dtpRuta.SelectedValue = _asignacionResponse.RouteId;
                dtpActivo.SelectedValue = _asignacionResponse.Activa;
            }
        }



        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpChoferes.SelectedValue == null ||
                    dtpAutoBuses.SelectedValue == null ||
                    dtpRuta.SelectedValue == null ||
                    dtpActivo.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar todos los campos antes de continuar.",
                        "Datos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                var asignacionRequest = new AsignacionRequest
                {
                    Id = _asignacionResponse?.Id ?? 0,
                    DriverId = (int)dtpChoferes.SelectedValue,
                    BusId = (int)dtpAutoBuses.SelectedValue,
                    RouteId = (int)dtpRuta.SelectedValue,
                    Activa = (bool)dtpActivo.SelectedValue
                };

                _asignacionController.AddAll(asignacionRequest);

                MessageBox.Show(
                    _asignacionResponse == null
                        ? "Asignación registrada exitosamente."
                        : "Asignación actualizada exitosamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Navigator.GoTo(new Table(_mainForm));
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error en la asignación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado al procesar la asignación.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
