
using ControlDeAutoBus.Core;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace ControlDeAutoBus
{
    public partial class FormMainHome : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormMainHome()
        {
            InitializeComponent();
            Navigator.MainForm = this;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelLayer.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColor
        {
            public static Color color = Color.FromArgb(24, 161, 251);
        }

       public void ActivarButtons(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarButtons();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                IconHome.IconChar = currentBtn.IconChar;
                IconHome.IconColor = color;
                LblHome.Text = currentBtn.Text;
            }
        }
        public void DesactivarButtons()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

       public void OpenChildForm(Form childForm0)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm0;
            childForm0.TopLevel = false;
            childForm0.FormBorderStyle = FormBorderStyle.None;
            childForm0.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm0);
            PanelDesktop.Tag = childForm0;
            childForm0.BringToFront();
            childForm0.Show();

        }

       public void Dashboard_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);
            Navigator.GoTo(new View.FormDashboard());
        }

       public void Choferes_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);
            Navigator.GoTo(new View.Drivers.Table(this));

        }

       public void Autobuses_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);
            Navigator.GoToBuses();

        }

       public void Rutas_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);
            Navigator.GoTo(new View.Routes.Table(this));

        }

       public void Asignación_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);
            Navigator.GoTo(new View.Assignments.Table(this));

        }

       public void Ajuste_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);
            Navigator.GoTo(new View.Settings.Table(this));

        }

       public void BtnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();

        }

       public void Reset()
        {
            DesactivarButtons();
            leftBorderBtn.Visible = false;
            IconHome.IconChar = IconChar.Home;
            IconHome.IconColor = Color.White;
            LblHome.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
       public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
       public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       public void FormMainHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }


       public void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       public void BtnBig_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

       public void BtnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
