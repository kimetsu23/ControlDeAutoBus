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
        private readonly FormMainHome _mainForm;
        public FormBus(FormMainHome mainHome )
        {
            InitializeComponent();
            _mainForm = mainHome;

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
