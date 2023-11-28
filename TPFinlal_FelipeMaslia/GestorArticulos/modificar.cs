
using Capa_Dominio;
using Capa_persistencia.sqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinlal_FelipeMaslia.GestorArticulos
{
    public partial class modificar : Form
    {
        public modificar()
        {
            InitializeComponent();
        }


        clsArticulos objArticulo = new clsArticulos();


        public int idArt;



        public void ListarCategorias()
        {
            clsArticulos objArticulo = new clsArticulos();
            comboBox3.DataSource = objArticulo.ListarCategorias();
            comboBox3.DisplayMember = "Descripcion";
            comboBox3.ValueMember = "Id";
        }
        public void ListarMarcas()
        {
            clsArticulos objArticulo = new clsArticulos();
            comboBox2.DataSource = objArticulo.ListarMarcas();
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "Id";
        }



      

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("Esta seguro que desea salir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(mensaje == DialogResult.Yes)
            {
                 this.Close();
            }
        }

        private void modificar_Load(object sender, EventArgs e)
        {
            //ListarCategorias();
            //ListarMarcas();
        }


        private void LimpiarCampos()
        {
            txt_codArticulo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            rich_descripcion.Text = string.Empty;
            txt_img.Text = string.Empty;
            txt_precio.Text = string.Empty;
            pb_imagenArticulo.Image = null;

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // validar si codigo articulo no existe en los registros
            try
            {
                infoArticulos art = new infoArticulos();

                art.codigoArticulo = txt_codArticulo.Text.ToUpper();
                string codigo = txt_codArticulo.Text.ToUpper();



                    art.nombreArticulo = txt_nombre.Text;
                    art.descripcionArticulo = rich_descripcion.Text;
                    art.imagenArticulo = txt_img.Text;
                    art.TipoMarca = new Marcas();
                    art.TipoMarca.id = Convert.ToInt32(comboBox2.SelectedValue);
                    art.TipoCat = new Categorias();
                    art.TipoCat.id = Convert.ToInt32(comboBox3.SelectedValue);
                    art.precio = Convert.ToDecimal(txt_precio.Text);
                  
                    objArticulo.EditarArticulo(art);
                    MessageBox.Show("Se ha Modificado con éxito","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpiarCampos();
                     Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            // Verificar que el sender realmente es un TextBox
            if (textBox != null)
            {
                // Permitir solo números y el carácter ","
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                {
                    e.Handled = true; // Ignorar el carácter ingresado
                }

                // Asegurar que solo se permite una coma
                if (e.KeyChar == ',' && textBox.Text.Contains(','))
                {
                    e.Handled = true; // Ignorar la segunda coma
                }
            }
        }
        public void cargarImagen2(string imagen)
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
        private void btn_cargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                cargarImagen2(archivo.FileName);

                string folderPath = ConfigurationManager.AppSettings["images-folder"];

                // Si mi carpeta por defecto no existe, entonces la creo
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Obtengo el nombre de archivo sin la extensión
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(archivo.SafeFileName);

                // Obtengo la extensión del archivo
                string fileExtension = Path.GetExtension(archivo.SafeFileName);

                // Genero un nombre de archivo único agregando un número secuencial
                string destinationFileName = GetUniqueFileName(folderPath, fileNameWithoutExtension, fileExtension);

                // Combino la carpeta de destino con el nuevo nombre de archivo
                string destinationPath = Path.Combine(folderPath, destinationFileName);

                // Copio el archivo en la carpeta con el nuevo nombre
                File.Copy(archivo.FileName, destinationPath);

                // Muestro en el TextBox el destino de la imagen
                txt_img.Text = destinationPath;
            }
        }
        private string GetUniqueFileName(string folderPath, string fileNameWithoutExtension, string fileExtension)
        {
            string uniqueFileName = fileNameWithoutExtension + fileExtension;
            int counter = 1;

            // Mientras exista un archivo con el mismo nombre, agrego un numero en secuencia
            while (File.Exists(Path.Combine(folderPath, uniqueFileName)))
            {
                uniqueFileName = $"{fileNameWithoutExtension}_{counter}{fileExtension}";
                counter++;
            }

            return uniqueFileName;
        }

        private void txt_img_Leave(object sender, EventArgs e)
        {
            cargarImagen2(txt_img.Text);
        }

        private void btn_seleccionarFoto_Click(object sender, EventArgs e)
        {
            // elk usuario al apretar el boton de cargar imagen, podra seleccionar imagenes del folder images-folder
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            // aqui establezco la carpeta donde voy a seleccionar el archivo imagen
            archivo.InitialDirectory = ConfigurationManager.AppSettings["images-folder"];
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                string imagenUrl = archivo.FileName;
                cargarImagen2(imagenUrl);// enseño la imagen seleccionada

                txt_img.Text = imagenUrl; // muestro la 
            }
        }
    }
}
