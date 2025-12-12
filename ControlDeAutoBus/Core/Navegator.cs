using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Core
{
    public class Navegator
    {
        public static FormMainHome MainForm { get; set; }

        public static void GoTo(Form form)
        {
            MainForm.OpenChildForm(form);
        }

        public static void GoToBuses()
        {
            MainForm.OpenChildForm(new View.Buses.Table(MainForm));
        }
    }
}
