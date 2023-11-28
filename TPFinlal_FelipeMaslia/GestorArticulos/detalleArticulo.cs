using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinlal_FelipeMaslia.GestorArticulos
{
    public partial class detalleArticulo : Form
    {
        public detalleArticulo()
        {
            InitializeComponent();
        }

        public void cargarImagen(string imagen)
        {
            try
            {
                pb_imagenArticulo.Load(imagen);
            }
            catch
            {
                pb_imagenArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");

            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detalleArticulo_Load(object sender, EventArgs e)
        {

        }
    }
}
