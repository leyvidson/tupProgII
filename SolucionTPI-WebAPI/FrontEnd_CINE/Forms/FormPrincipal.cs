using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace FrontEnd_CINE.Forms
{
    public partial class FormPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public FormPrincipal()
        {
            InitializeComponent();
            btnRestaurar.Visible = false;
            WindowState = FormWindowState.Maximized;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,46);
            MenuLeft.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(95,77,221);
            public static Color color4 = Color.FromArgb(249,89,155);
            public static Color color5 = Color.FromArgb(24,163,251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Black;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que quiere dejar la App?"
                ,"SALIENDO",MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible=false;
        }
        
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();            
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButtonPeliculas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color1);
            AbrirFormInPanel(new FormPelicula());
        }

        private void iconButtonClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirFormInPanel(new FormClientes());
        }

        private void iconButtonReservas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormInPanel(new FormReservas());
        }

        private void iconButtonFunciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormInPanel(new FormFunciones());
        }

        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            if (MenuLeft.Width == 250)
            {
                MenuLeft.Width = 58;
            }
            else MenuLeft.Width = 250;
        }

        private void iconButtonInicio_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            Application.Restart();
            Application.Exit();
        }

        private void iconButtonConsultas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirFormInPanel(new FormConsultas());
        }

        private void iconButtonCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere dejar la App?"
               , "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question
               , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void iconButtonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconButtonRestaurar.Visible = true;
            iconButtonMaximizar.Visible = false;
        }

        private void iconButtonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconButtonRestaurar.Visible = false;
            iconButtonMaximizar.Visible = true;
        }

        private void iconButtonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
