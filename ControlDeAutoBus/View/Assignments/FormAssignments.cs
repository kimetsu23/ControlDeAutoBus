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
        private ChoferesController _choferesController => AppServices.ChoferesController;
        private BusController _busController => AppServices.BusController;
        private RutasController _routesController => AppServices.RutasController;
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
            // Choferes
            dtpChoferes.DataSource = _asignacionController.GetChoferes();
            dtpChoferes.DisplayMember = "Name";
            dtpChoferes.ValueMember = "Id";
            dtpChoferes.SelectedIndex = -1;

            // Autobuses
            dtpAutoBuses.DataSource = _asignacionController.GetAutobuses();
            dtpAutoBuses.DisplayMember = "MarcaModelo";
            dtpAutoBuses.ValueMember = "Id";
            dtpAutoBuses.SelectedIndex = -1;

            // Rutas
            dtpRuta.DataSource = _asignacionController.GetRutas();
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
                dtpChoferes.Text = _asignacionResponse.DriverNombre;
                dtpAutoBuses.Text = _asignacionResponse.BusNombre;
                dtpRuta.Text = _asignacionResponse.RutaNombre;
                dtpActivo.SelectedValue = _asignacionResponse.Activa;
            }
        }

  

        public void btnRegistrar_Click(object sender, EventArgs e)
        {

            var asignacionRequest = new AsignacionRequest
            {
                Id = _asignacionResponse?.Id ?? 0,
                DriverId = Convert.ToInt32(dtpChoferes.SelectedValue),
                BusId = Convert.ToInt32(dtpAutoBuses.SelectedValue),
                RouteId = Convert.ToInt32(dtpRuta.SelectedValue),
                Activa = Convert.ToBoolean(dtpActivo.SelectedValue)
            };
            _asignacionController.AddAll(asignacionRequest);
            Navigator.GoTo(new Table(_mainForm));

        }
    }
}
