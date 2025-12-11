using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeAutoBus.View.Routes
{
    public partial class FormRouter : Form
    {
        private readonly FormMainHome _mainForm;
        public FormRouter(FormMainHome mainForm)
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

        }
    }
}
