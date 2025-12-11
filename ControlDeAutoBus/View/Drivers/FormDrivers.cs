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
        public FormDrivers(FormMainHome mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            Table driversTable = new Table(_mainForm);
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
