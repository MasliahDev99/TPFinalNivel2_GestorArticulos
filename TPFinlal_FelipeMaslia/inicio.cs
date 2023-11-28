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
using TPFinlal_FelipeMaslia.GestorArticulos;
using FontAwesome.Sharp;
using System.Windows.Media;


namespace TPFinlal_FelipeMaslia
{
    public partial class inicio : Form
    {
        // codigo para poder mover el formulario 
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        //---------------------------------------------------------------------------------------------

        private Form currentChildForm;
        private IconButton currentBoton;
        private Panel leftBorderBtn;

        // variables para el rectangulo de aumentar o disminuir tamanio del formulario
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        //----------------------------------------------------------
        public inicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 31);
            contenedorGestor.Controls.Add(leftBorderBtn);   

        }

        private void restaurarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurarVentana.Visible = false;
            maximizarVentana.Visible = true;
        }

        private void maximizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizarVentana.Visible = false;
            restaurarVentana.Visible = true;
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void contenedorCentral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
            public static System.Drawing.Color color7 = System.Drawing.Color.FromArgb(24, 161, 251);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(childForm);
            panelCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_formActual.Text = childForm.Text;
        }

        private void ContenedorSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
           
        }

   

        private void iconButton9_Click_1(object sender, EventArgs e)
        {
            contenedorGestor.Visible = true;
           
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Activateboton(sender,RGBColors.color1);
            OpenChildForm(new ingresoArticulos());
            
        }
        private void Reset()
        {
            DisableButton();
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            lbl_formActual.Text = "Home";

        }

       

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
            currentChildForm.Close();
            contenedorGestor.Visible = false;
            Reset();
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            contenedorGestor.Visible = false;
            Reset();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            contenedorGestor.Visible = false;
            Reset();
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            contenedorGestor.Visible=false;
            Reset();
        }
       
        private void Activateboton(object senderbtn, System.Drawing.Color color)
        {
            if(senderbtn!=null)
            {
                DisableButton();
                //botones
                currentBoton = (IconButton)senderbtn;
                currentBoton.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBoton.ForeColor = color;
                currentBoton.TextAlign = ContentAlignment.MiddleCenter;
                currentBoton.IconColor = color;
                currentBoton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBoton.ImageAlign = ContentAlignment.MiddleRight;
                iconCurrentChildForm.IconChar = currentBoton.IconChar;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBoton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // icon current child form
                iconCurrentChildForm.IconChar = currentBoton.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBoton != null)
            {

                currentBoton.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
                currentBoton.ForeColor = System.Drawing.Color.White;
                currentBoton.TextAlign = ContentAlignment.MiddleLeft;
                currentBoton.IconColor = System.Drawing.Color.White;
                currentBoton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBoton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Activateboton(sender, RGBColors.color5);
            OpenChildForm(new buscarArticulo());
        }

        private void listado_Click(object sender, EventArgs e)
        {
            Activateboton(sender, RGBColors.color4);
            OpenChildForm(new Mantenimiento());
        }

        private void btn_detalleART_Click(object sender, EventArgs e)
        {
            Activateboton(sender, RGBColors.color3);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Activateboton(sender, RGBColors.color2);
        }



        private void Eliminar_Click(object sender, EventArgs e)
        {
            Activateboton(sender, RGBColors.color6);
        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelCentral.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(System.Drawing.Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, System.Drawing.Color.Transparent, sizeGripRectangle);
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Esta seguro que desea cerrar sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                this.Close();   
            }
        }
       
        private void inicio_Load(object sender, EventArgs e)
        {
       
        }
    }
}
