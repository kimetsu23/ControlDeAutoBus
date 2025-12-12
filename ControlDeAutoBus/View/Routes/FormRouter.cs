using ControlDeAutoBus.Controller;
using ControlDeAutoBus.Core;
using ControlDeAutoBus.Domain.Response;

namespace ControlDeAutoBus.View.Routes
{
    public partial class FormRouter : Form
    {
        private readonly FormMainHome _mainForm;
        private RutasController _routesController => AppServices.RutasController;
        private RutasResponse _ruta;
        public FormRouter(FormMainHome mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        public FormRouter(RutasResponse ruta)
        {
            InitializeComponent();
            _ruta = ruta;
            LoadRouteData();
        }
        public void btnCancelar_Click(object sender, EventArgs e)
        {
            Navigator.GoTo(new Table(_mainForm));
        }
        private void LoadRouteData()
        {
            if (_ruta == null) return;
            txtNombreRuta.Text = _ruta.NameRoute;
            btnRegistrar.Text = "Editar";
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            var rutaRequest = new Domain.Request.RutasRequest
            {
                Id = _ruta?.Id ?? 0,
                NameRoute = txtNombreRuta.Text,
            };
            _routesController.AddOrUpdateRoute(rutaRequest);
            MessageBox.Show(
                _ruta == null ? "Ruta registrada exitosamente." : "Ruta actualizada exitosamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            Navigator.GoTo(new Table(_mainForm));

        }
    }
}
