using ControlDeAutoBus.Controller;
using ControlDeAutoBus.Core;
using ControlDeAutoBus.Domain.Request;
using ControlDeAutoBus.Domain.Response;
using FontAwesome.Sharp;

namespace ControlDeAutoBus.View.Settings
{
    public partial class FormSettings : Form
    {
        private readonly FormMainHome _mainForm;
        private UsuarioController _usuarioController = AppServices.UsuarioController;
        private UsuarioResponse _UserResponse;
        public FormSettings(FormMainHome mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            LoadRoles();
        }
        public FormSettings(UsuarioResponse userResponse)
        {
            InitializeComponent();
            _UserResponse = userResponse;
            LoadRoles();
            LoadUser();
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            Navigator.GoTo(new Table(_mainForm));
        }
        private void LoadRoles()
        {
            var roles = new List<dynamic>
            {
                new { Id = 1, Nombre = "Admin" },
                new { Id = 2, Nombre = "Chofer" },
                new { Id = 3, Nombre = "Usuario" }
            };

            dtpRol.DataSource = roles;
            dtpRol.DisplayMember = "Nombre";
            dtpRol.ValueMember = "Id";
        }

        private void LoadUser()
        {
            if (_UserResponse != null)
            {
                txtNombre.Text = _UserResponse.Name;
                txtApellido.Text = _UserResponse.LastName;
                txtUsuario.Text = _UserResponse.User;
                txtClave.Text = _UserResponse.Password;

                txtClave.Text = "";

                dtpRol.SelectedItem = _UserResponse.Rol;
            }
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            var userRequest = new UsuarioRequest
            {
                Id = _UserResponse?.Id ?? Guid.Empty,
                Name = txtNombre.Text,
                LastName = txtApellido.Text,
                User = txtUsuario.Text,
                Password = txtClave.Text,
                Rol = Convert.ToInt32(dtpRol.SelectedValue)
            };
            if (_UserResponse != null && string.IsNullOrWhiteSpace(txtClave.Text))
            {
                userRequest.Password = null;
            }
            else
            {
                userRequest.Password = txtClave.Text; 
            }

            _usuarioController.AddOrUpdateUser(userRequest);
            MessageBox.Show(
                _UserResponse == null ? "Usuario registrado exitosamente." : "Usuario actualizado exitosamente."

            );

            Navigator.GoTo(new Table(_mainForm));
        }
        private void IconEye_MouseEnter(object sender, EventArgs e)
        {
            IconEye.IconColor = Color.FromArgb(33, 37, 41);
        }

        private void IconEye_MouseLeave(object sender, EventArgs e)
        {
            IconEye.IconColor = Color.FromArgb(108, 117, 125);
        }

        private void BtnVerClave_Click(object sender, EventArgs e)
        {
            if (txtClave.UseSystemPasswordChar)
            {
                // Mostrar contraseña
                txtClave.UseSystemPasswordChar = false;
                IconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                IconEye.IconColor = Color.FromArgb(13, 110, 253);
            }
            else
            {
                // Ocultar contraseña
                txtClave.UseSystemPasswordChar = true;
                IconEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                IconEye.IconColor = Color.FromArgb(108, 117, 125); 
            }
        }
    }
}