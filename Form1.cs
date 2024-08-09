using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Runtime.InteropServices;

namespace Rocket_ground_station
{
    public partial class Form1 : Form
    {

        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //constructor
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 66);
            panelMenu.Controls.Add(leftBorderBtn);
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);//paneltitle renk
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }

        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

            //methods
            private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button vurgu
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;




            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            homeTextLabel.Text= childForm.Text;

        }
        private void aliciTestButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new AliciTest());
        }

        private void vericiTestButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Form3());
        }

        private void hızTestButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new HIZ());        }

        private void takimHakkindaButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Takim());
        }

        private void yerIstasyonuButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new YerIstasyonu()); 
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salgurLogoPictureBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            homeTextLabel.Text = "Home";
        }


        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);  


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1202, 764);
        }

        private void kapamaIconButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kapamaIconButton_MouseEnter(object sender, EventArgs e)
        {
            kapamaIconButton.BackColor = Color.Thistle;
        }

        private void kapamaIconButton_MouseLeave(object sender, EventArgs e)
        {
            kapamaIconButton.BackColor = SystemColors.Control;
        }

        private void salgurLogoPictureBox_MouseEnter(object sender, EventArgs e)
        {
            salgurLogoPictureBox.BackColor = Color.MediumPurple;
        }

        private void salgurLogoPictureBox_MouseLeave(object sender, EventArgs e)
        {
            salgurLogoPictureBox.BackColor = Color.FromArgb(26,25,62); ;
        }
    }
}
