using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeAutoBus.View
{
    public partial class FormAssignments : Form
    {
        private readonly FormMainHome _mainForm;
        public FormAssignments(FormMainHome mainHome)
        {
            InitializeComponent();
            _mainForm = mainHome;

        }
    }
}
