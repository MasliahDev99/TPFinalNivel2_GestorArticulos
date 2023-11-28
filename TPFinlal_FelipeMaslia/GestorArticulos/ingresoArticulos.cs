using Capa_persistencia.sqlServer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Controls;
using Capa_Dominio;


namespace TPFinlal_FelipeMaslia.GestorArticulos
{
    public partial class ingresoArticulos : Form
    {

        clsArticulos objArticulo = new clsArticulos();
       

        
        public ingresoArticulos()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }


        private void txt_codArticulo_Enter(object sender, EventArgs e)
        {
            if(txt_codArticulo.Text == "Código de artículo")
            {
                txt_codArticulo.Text = string.Empty;    
            }
        }

        private void txt_codArticulo_Leave(object sender, EventArgs e)
        {
            if(txt_codArticulo.Text == string.Empty)
            {

                txt_codArticulo.Text = "Código de artículo";
            }
        }

        private void txt_nombreArticulo_Enter(object sender, EventArgs e)
        {
            if(txt_nombre.Text == "Nombre de artículo")
            {
                txt_nombre.Text = string.Empty;
            }
        }

        private void txt_nombreArticulo_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == string.Empty)
            {
                txt_nombre.Text = "Nombre de artículo";
            }
        }

        private void cb_MarcaArticulo_Enter(object sender, EventArgs e)
        {
            if(cb_MarcaArticulo.Text == "Seleccione Marca")
            {
                cb_MarcaArticulo.Text = string.Empty;
            }
        }

        private void cb_MarcaArticulo_Leave(object sender, EventArgs e)
        {
            if(cb_MarcaArticulo.Text == string.Empty)
            {
                cb_MarcaArticulo.Text = "Seleccione Marca";
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if(comboBox1.Text == string.Empty)
            {
                comboBox1.Text = "Seleccione categoría";
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Seleccione categoría")
            {
                comboBox1.Text = string.Empty;  
            }
        }

        private void rich_descripcion_Leave(object sender, EventArgs e)
        {
            if(rich_descripcion.Text == string.Empty)
            {
                rich_descripcion.Text = "Descripción del artículo";
            }
        }

        private void rich_descripcion_Enter(object sender, EventArgs e)
        {
            if(rich_descripcion.Text == "Descripción del artículo")
            {
                rich_descripcion.Text = string.Empty;   
            }
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            if(txt_precio.Text == string.Empty)
            {
                txt_precio.Text = "Precio";
            }
        }

        private void txt_precio_Enter(object sender, EventArgs e)
        {
            if(txt_precio.Text == "Precio")
            {
                txt_precio.Text= string.Empty;
            }
        }

     



       

        private void btn_cargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Seleccione una imágen de formato png del artículo...");
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw ex;
            }
        }

        private void ingresoArticulos_Load(object sender, EventArgs e)
        {
         

            ListarMarcas();
            ListarCategorias();
            ListarArticulos();


            LimpiarCampos();
        }

        private void ListarCategorias()
        {
            clsArticulos objArticulo = new clsArticulos();
            cb_categoria.DataSource = objArticulo.ListarCategorias();
            cb_categoria.DisplayMember = "Descripcion";
            cb_categoria.ValueMember = "Id";
            cb_categoria.DropDownStyle = ComboBoxStyle.DropDownList; 
        }
        private void ListarMarcas()
        {
            clsArticulos objArticulo = new clsArticulos();
            cb_marca.DataSource = objArticulo.ListarMarcas();
            cb_marca.DisplayMember = "Descripcion";
            cb_marca.ValueMember = "Id";
            cb_marca.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void ListarArticulos()
        {
            clsArticulos objArticulo = new clsArticulos();
           dgvListadoAritculos.DataSource = objArticulo.ListarProductos();

            dgvListadoAritculos.Columns[6].Visible = false; // dejo oculto la columna de la imagen

        }



        private void cargarImagen(string imagen)
        {
            try
            {
                pb_imagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pb_imagenArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                throw ex;
            }
        }
        private void cargarImagen2(string imagen)
        {
            try
            {
                pb_imagen.Load(imagen);
            }
            catch 
            {
                pb_imagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                
            }
        }
        private void btn_cargarImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                cargarImagen(archivo.FileName);

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
                cargarImagen(imagenUrl);// ensenio la imagen seleccionada

                txt_img.Text = imagenUrl;
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
        private void LimpiarCampos()
        {
            txt_nombre.Text = "Nombre de artículo"; 
            rich_descripcion.Text = "Descripción del artículo";
            txt_img.Text = string.Empty;
            txt_precio.Text = "Precio";
            pb_imagenArticulo.Image = null;
            cb_marca.SelectedIndex = 0;
            cb_categoria.SelectedIndex = 0;
            ActualizarCodigoArticulo(cb_marca.Text); // actualizo el codigo de articulo con la marca


        }
        private bool verificarInicialCodigo(string codigo)
        {
            if (codigo[0] == cb_marca.Text[0])
            {
                return true;
            }
            return false;
        }
        private bool formularioCompleto()
        {
            if(txt_codArticulo.Text == "Código de artículo" ||  txt_nombre.Text == "Nombre de artículo" || rich_descripcion.Text == "Descripción del artículo" || txt_precio.Text == "Precio")
            {
                MessageBox.Show("Debe completar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
           
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {

            // validar si codigo articulo no existe en los registros
            try
            {
                infoArticulos art = new infoArticulos();
                clsArticulos consultaArticulo = new clsArticulos(); 
                art.codigoArticulo = txt_codArticulo.Text.ToUpper();
                string codigo = txt_codArticulo.Text.ToUpper();
                bool verificarInicial = verificarInicialCodigo(codigo);
                bool NoexisteCodigo = consultaArticulo.existeCodigo(codigo) < 1;
                if (formularioCompleto())
                {

                    if (NoexisteCodigo && verificarInicial)
                    {


                        art.nombreArticulo = txt_nombre.Text;
                        art.descripcionArticulo = rich_descripcion.Text;
                        art.imagenArticulo = txt_img.Text;
                        art.TipoMarca = new Marcas();
                        art.TipoMarca.id = Convert.ToInt32(cb_marca.SelectedValue);
                        art.TipoCat = new Categorias();
                        art.TipoCat.id = Convert.ToInt32(cb_categoria.SelectedValue);
                        art.precio = Convert.ToDecimal(txt_precio.Text);
                        objArticulo.InsertarArticulos(art);
                        MessageBox.Show("Se ha ingresado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarArticulos(); // actualizo luego de ingresar



                    }//  fin del if de codigo unico
                    else if (!NoexisteCodigo)
                    {
                        MessageBox.Show("El código de artículo " + art.codigoArticulo + " ingresado ya esta registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (!verificarInicial) // 
                    {
                        MessageBox.Show("Error: La letra incial del código no coincide con la incial de marca seleccionada", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                }// fin del if de formulario completo

            } catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }

            LimpiarCampos();
        }

        private void txt_img_Leave(object sender, EventArgs e)
        {
            cargarImagen(txt_img.Text);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvListadoAritculos.SelectedRows.Count > 0)
            {
                infoArticulos eliminarArticulo = new infoArticulos();   
                eliminarArticulo.codigoArticulo = dgvListadoAritculos.CurrentRow.Cells["Codigo"].Value.ToString();

                DialogResult mensaje = MessageBox.Show("Esta seguro que desea eliminar el artículo " +eliminarArticulo.codigoArticulo +" ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(mensaje == DialogResult.Yes)
                {
                objArticulo.EliminarArticulos(eliminarArticulo);
                MessageBox.Show("El artículo se ha eliminado exitosamente","", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                ListarArticulos();
                }
            }
            else
                MessageBox.Show("Seleccione una fila","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

      

        private void modificar_Click(object sender, EventArgs e)
        {
            if(dgvListadoAritculos.SelectedRows.Count > 0)
            {
            modificar fmModificar = new modificar();
                fmModificar.ListarCategorias();
                fmModificar.ListarMarcas();
                
                fmModificar.txt_codArticulo.Text = dgvListadoAritculos.CurrentRow.Cells["Codigo"].Value.ToString();
                fmModificar.txt_nombre.Text = dgvListadoAritculos.CurrentRow.Cells["Nombre"].Value.ToString();
                fmModificar.comboBox2.Text = dgvListadoAritculos.CurrentRow.Cells[3].Value.ToString();
                fmModificar.comboBox3.Text = dgvListadoAritculos.CurrentRow.Cells[4].Value.ToString();
                fmModificar.rich_descripcion.Text = dgvListadoAritculos.CurrentRow.Cells["DescripcionArticulo"].Value.ToString();
                fmModificar.txt_precio.Text = dgvListadoAritculos.CurrentRow.Cells[5].Value.ToString();
                string url = dgvListadoAritculos.CurrentRow.Cells[6].Value.ToString();
                fmModificar.cargarImagen2(url);
                fmModificar.txt_img.Text = url; // muestro el url / ubicación de la imagen en el textbox
                fmModificar.ShowDialog();
                ListarArticulos();

            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar una fila", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

          
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



        private void cb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView marcaSeleccionada = cb_marca.SelectedItem as DataRowView;
           


            if (marcaSeleccionada != null)
            {
                string nombreMarca = marcaSeleccionada["Descripcion"].ToString();
                ActualizarCodigoArticulo(nombreMarca);
            }
        }

        private void ActualizarCodigoArticulo(string marca)
        {
            
            string codigo = ObtenerCodigoArticulo(marca);
            txt_codArticulo.Text = codigo;

            
        }

        private string ObtenerCodigoArticulo(string marca)// arreglar, si agrego marcas que comienzen con la misma letra puede a ver incongruencias
        {
            if (!string.IsNullOrEmpty(marca))
            {
                return marca[0].ToString().ToUpper();  
            }
            else
            {
                return string.Empty; // medio al dope
            }
        }
       

        private void dgvListadoAritculos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoAritculos.CurrentRow != null)
            {
                DataRow filaSeleccionada = ((DataRowView)dgvListadoAritculos.CurrentRow.DataBoundItem).Row;

                if (filaSeleccionada != null && !string.IsNullOrEmpty(filaSeleccionada["ImagenUrl"].ToString()))
                {
                    string urlImagen = filaSeleccionada["ImagenUrl"].ToString();
                    cargarImagen2(urlImagen);
                }
                else
                {
                    cargarImagen2("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }
        }

    }
}
