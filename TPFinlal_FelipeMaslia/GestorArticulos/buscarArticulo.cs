using Capa_Dominio;
using Capa_persistencia.sqlServer;
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
    public partial class buscarArticulo : Form
    {
        public buscarArticulo()
        {
            InitializeComponent();
        }
        clsArticulos objArticulo = new clsArticulos();  

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void txt_buscador_Leave(object sender, EventArgs e)
        {
            if(txt_buscador.Text == string.Empty)
            {
                txt_buscador.Text = "Buscar..";
            }
        }

        private void txt_buscador_Enter(object sender, EventArgs e)
        {
            if(txt_buscador.Text == "Buscar..")
            {
                txt_buscador.Text = string.Empty;
            }
        }

        private void cb_filtros_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_filtros.Checked == true)
            {
                ContenedorFiltros.Visible = true;
                btn_bs.Visible = false;
                txt_buscador.Enabled = false;
            }
            else
            {
                ContenedorFiltros.Visible=false;

                btn_bs.Visible=true;
                txt_buscador.Enabled=true;
                LimpiarCampos();
            }
        }
       
        private void modificar_Click(object sender, EventArgs e)
        {
            modificar fmModifc = new modificar();
            fmModifc.ShowDialog();  
        }

        private void buscarArticulo_Load(object sender, EventArgs e)
        {
            ListarArticulos();
            
        }

        private void ListarArticulos()
        {
            clsArticulos objArticulo = new clsArticulos();
             DGV_ListadoArticulos.DataSource = objArticulo.ListarProductos();


            DGV_ListadoArticulos.Columns[6].Visible = false;
        }
      
        private void BusquedaRapida()
        {
            clsArticulos articulo = new clsArticulos();
            infoArticulos nuevoArticulo = new infoArticulos();
            nuevoArticulo.nombreArticulo = txt_buscador.Text;

            // verificare que si el nombre del articulo no existe emita un mensaje de error y no muestre la consulta vacia
            if (string.IsNullOrWhiteSpace(nuevoArticulo.nombreArticulo))
            {
                MessageBox.Show("Por favor, ingresa un nombre para realizar la búsqueda.", "Búsqueda vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarArticulos();
                txt_buscador.Text = "Buscar..";
            }
            else
            {
                var resultado = articulo.ListarPorNombre(nuevoArticulo);
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    DGV_ListadoArticulos.DataSource = articulo.ListarPorNombre(nuevoArticulo);
                    DGV_ListadoArticulos.Columns[6].Visible = false;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para el nombre ingresado.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarArticulos();
                    txt_buscador.Text = "Buscar..";
                }
               
            }
           
        }
        private void txt_buscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BusquedaRapida();
            }
        }

        private void LimpiarCampos()
        {
            txt_fPrecioMin.Text = "Precio Mínimo";
            txt_fPrecioMax.Text = "Precio Máximo";
        }
        
        private void btnBuscarFiltros_Click(object sender, EventArgs e)
        {
            clsArticulos articulo   = new clsArticulos();
            decimal precioMin, precioMax;

            bool esPrecioMinimo = decimal.TryParse(txt_fPrecioMin.Text, out precioMin);
            bool esPrecioMaximo = decimal.TryParse(txt_fPrecioMax.Text, out precioMax);

            if (esPrecioMinimo || txt_fPrecioMin.Text != "Precio Minimo")
            {
                if (esPrecioMaximo || txt_fPrecioMax.Text != "Precio Maximo")
                {
                    if (esPrecioMinimo && esPrecioMaximo)
                    {
                       
                  
                        if(precioMin <= precioMax)
                        {
                           
                            if ( precioMin >= 0  && precioMin >= articulo.ObtenerPrecioMinimo())
                            {
                                if (precioMax >= 0 && precioMax <= articulo.ObtenerPrecioMaximo())
                                {

                                    var resultado = articulo.ListarPorRangoPrecio(precioMin, precioMax);
                                    if (resultado != null && resultado.Rows.Count > 0)
                                    {
                                        DGV_ListadoArticulos.DataSource = articulo.ListarPorRangoPrecio(precioMin, precioMax);
                                        DGV_ListadoArticulos.Columns[6].Visible = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No existen productos con el rango seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LimpiarCampos();
                                        ListarArticulos();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Precio máximo es US$" + articulo.ObtenerPrecioMaximo() +" ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LimpiarCampos();
                                    ListarArticulos();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Precio mínimo US$" + articulo.ObtenerPrecioMinimo() + " ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                                ListarArticulos();
                            }
                            
                            

                        }
                        else
                        {
                            MessageBox.Show("Error: precio mínimo debe ser menor a precio maximo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LimpiarCampos();
                            ListarArticulos();
                        }
                    }
                    else if (esPrecioMinimo)
                    {

                        if (precioMin >= 0)
                        {
                            decimal precioMinimoRegistrado = articulo.ObtenerPrecioMinimo();
                            decimal precioMaximoRegistrado = articulo.ObtenerPrecioMaximo();

                            if (precioMin >= precioMinimoRegistrado && precioMin <= precioMaximoRegistrado)
                            {
                                var resultado = articulo.ListarPorPrecioMin(precioMin);
                                if (resultado != null && resultado.Rows.Count > 0)
                                {
                                    DGV_ListadoArticulos.DataSource = resultado;
                                    DGV_ListadoArticulos.Columns[6].Visible = false;
                                }
                                else
                                {
                                    MessageBox.Show("No existen productos que cumplan la búsqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LimpiarCampos();
                                    ListarArticulos();
                                }
                            }
                            else
                            {
                                MessageBox.Show($"El precio mínimo debe estar entre US${precioMinimoRegistrado} y US${precioMaximoRegistrado}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                                ListarArticulos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: el precio mínimo debe ser positivo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LimpiarCampos();
                            ListarArticulos();
                        }

                        

                    }
                    else if (esPrecioMaximo)
                    {
                       
                        
                        if (precioMax >= 0)
                        {
                            if (precioMax <= articulo.ObtenerPrecioMaximo())
                            {


                                var resultado = articulo.ListarPorPrecioMax(precioMax);
                                if (resultado != null && resultado.Rows.Count > 0)
                                {
                                    DGV_ListadoArticulos.DataSource = articulo.ListarPorPrecioMax(precioMax);
                                    DGV_ListadoArticulos.Columns[6].Visible = false;
                                }
                                else
                                {
                                    MessageBox.Show("No existen productos que cumplan la búsqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LimpiarCampos();
                                    ListarArticulos();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Precio máximo es US$" + articulo.ObtenerPrecioMaximo() , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                                ListarArticulos();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error: precio maximo debe ser positivo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LimpiarCampos();
                            ListarArticulos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresa un tipo de búsqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido para el precio máximo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para el precio mínimo.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimpiarCampos();
            }
           
        }









        private void txt_fPrecioMin_Leave(object sender, EventArgs e)
        {
            if (txt_fPrecioMin.Text == string.Empty)
            {
                txt_fPrecioMin.Text = "Precio Mínimo";
            }
        }

        private void txt_fPrecioMin_Enter(object sender, EventArgs e)
        {
            if(txt_fPrecioMin.Text == "Precio Mínimo")
            {
                txt_fPrecioMin.Text = string.Empty ;
            }
        }

        private void txt_fPrecioMax_Leave(object sender, EventArgs e)
        {
            if (txt_fPrecioMax.Text == string.Empty)
            {
                txt_fPrecioMax.Text = "Precio Máximo";
            }
        }

        private void txt_fPrecioMax_Enter(object sender, EventArgs e)
        {
            if (txt_fPrecioMax.Text == "Precio Máximo")
            {
                txt_fPrecioMax.Text = string.Empty;
            }
        }

       

     
        private void cargarImagen(string imagen)
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
        private void DGV_ListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_ListadoArticulos.CurrentRow != null)
            {
                DataRow filaSeleccionada = ((DataRowView)DGV_ListadoArticulos.CurrentRow.DataBoundItem).Row;

                if (filaSeleccionada != null && !string.IsNullOrEmpty(filaSeleccionada["ImagenUrl"].ToString()))
                {
                    string urlImagen = filaSeleccionada["ImagenUrl"].ToString();
                    cargarImagen(urlImagen);
                }
                else
                {
                    cargarImagen("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            infoArticulos eliminarArticulo = new infoArticulos();
            if (DGV_ListadoArticulos.SelectedRows.Count > 0)
            {
                eliminarArticulo.codigoArticulo = DGV_ListadoArticulos.CurrentRow.Cells["Codigo"].Value.ToString();
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el artículo, código: " +eliminarArticulo.codigoArticulo+" ?","Verifique",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                objArticulo.EliminarArticulos(eliminarArticulo);
                MessageBox.Show("El artículo se ha eliminado exitosamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ListarArticulos();
                }
            
            }
            else
                MessageBox.Show("Seleccione una fila","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            DGV_ListadoArticulos.ClearSelection();
        }

        private void btn_bs_Click(object sender, EventArgs e)
        {
            BusquedaRapida();
        }

        private void txt_fPrecioMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fPrecioMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_fPrecioMax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            
            ListarArticulos();
            LimpiarCampos();
            txt_buscador.Text = "Buscar..";
        }

        private void btn_detalleART_Click(object sender, EventArgs e)
        {
            if(DGV_ListadoArticulos.SelectedRows.Count > 0)
            {
            detalleArticulo verDetalle = new detalleArticulo();
            verDetalle.txt_codArticulo.Text = DGV_ListadoArticulos.CurrentRow.Cells["Codigo"].Value.ToString();
                verDetalle.txt_nombre.Text = DGV_ListadoArticulos.CurrentRow.Cells["Nombre"].Value.ToString();
                verDetalle.txt_marca.Text = DGV_ListadoArticulos.CurrentRow.Cells["MARCA"].Value.ToString();
                verDetalle.txt_categoria.Text = DGV_ListadoArticulos.CurrentRow.Cells["Categoria"].Value.ToString();
                verDetalle.rich_descripcion.Text = DGV_ListadoArticulos.CurrentRow.Cells["DescripcionArticulo"].Value.ToString();
                verDetalle.txt_precio.Text = DGV_ListadoArticulos.CurrentRow.Cells[5].Value.ToString();
               
                string imagenUrl = DGV_ListadoArticulos.CurrentRow.Cells[6].Value.ToString();     // obtengo el url de la imagen
                verDetalle.cargarImagen(imagenUrl); // funcionooooa
                verDetalle.ShowDialog();
                ListarArticulos();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
            }
        }
    }
}
