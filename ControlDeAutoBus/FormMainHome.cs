using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void ActivarButtons(object senderBtn, Color color)
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

        private void OpenChildForm(Form childForm0)
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

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);
        }

        private void Choferes_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);

        }

        private void Autobuses_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);

        }

        private void Rutas_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);

        }

        private void Asignación_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);

        }

        private void Ajuste_Click(object sender, EventArgs e)
        {
            ActivarButtons(sender, RGBColor.color);

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void Reset()
        {
            DesactivarButtons();
            leftBorderBtn.Visible = false;
            IconHome.IconChar = IconChar.Home;
            IconHome.IconColor = Color.White;
            LblHome.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormMainHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
