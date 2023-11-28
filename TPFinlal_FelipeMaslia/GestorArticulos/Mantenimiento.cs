using Capa_Dominio;
using Capa_persistencia.sqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinlal_FelipeMaslia.GestorArticulos
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }
        clsArticulos objArticulo = new clsArticulos();  
        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            ListaMarcas();
            ListaCategorias();

         
        }

        private void ListaCategorias()
        {
            clsArticulos objArticulo = new clsArticulos();
           dgv_Categoria.DataSource = objArticulo.ListarCategorias();
            dgv_Categoria.ClearSelection();
        }
        private void ListaMarcas()
        {
            clsArticulos objArticulo = new clsArticulos();
           dgv_Marcas.DataSource = objArticulo.ListarMarcas();
            dgv_Marcas.ClearSelection();

        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            
            Marcas marca    = new Marcas();
            Categorias categoria = new Categorias(); 
            clsArticulos nuevo = new clsArticulos();  
            marca.descripcion = txt_nuevaMarca.Text;
            categoria.descripcion = txt_nuevaCategoria.Text;

            bool MarcaUnica = nuevo.existeMarca(marca.descripcion) > 0;
            bool CategoriaUnica = nuevo.existeCategoria(categoria.descripcion) > 0;

            if(rb_soloMarca.Checked)
            {
                if (!MarcaUnica)
                {
                    nuevo.InsertarMarcas(marca);
                    MessageBox.Show("Marca: " + txt_nuevaMarca.Text + " se ha agregado con éxito","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: La marca ingresada ya fue cargada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }else if(rb_soloCategoria.Checked)
            {
                if (!CategoriaUnica)
                {
                    nuevo.InsertarCategorias(categoria);
                    MessageBox.Show("Categoría: " + txt_nuevaCategoria.Text + " se ha agregado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: La categoría ingresada ya fue cargada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_ambas.Checked)
            {
                if (!MarcaUnica && !CategoriaUnica)
                {
                    nuevo.InsertarMarcas(marca);
                    nuevo.InsertarCategorias(categoria);
                    MessageBox.Show("Marca: " + txt_nuevaMarca.Text + "\nCategoría: " + txt_nuevaCategoria.Text + " se han agregado con éxito\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: La marca y cateogría ingresada ya fueron cargadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ListaMarcas();
            ListaCategorias();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_nuevaCategoria.Text = "Nueva Categoría";
            txt_nuevaMarca.Text = "Nueva Marca";
        }

        private void txt_nuevaMarca_Leave(object sender, EventArgs e)
        {
            if(txt_nuevaMarca.Text == string.Empty)
            {
                txt_nuevaMarca.Text = "Nueva Marca";
            }
        }

        private void txt_nuevaMarca_Enter(object sender, EventArgs e)
        {
            if(txt_nuevaMarca.Text == "Nueva Marca")
            {
                txt_nuevaMarca.Text = string.Empty; 
            }
        }

        private void txt_nuevaCategoria_Leave(object sender, EventArgs e)
        {
            if(txt_nuevaCategoria.Text == string.Empty)
            {
                txt_nuevaCategoria.Text = "Nueva Categoría";
            }
        }

        private void txt_nuevaCategoria_Enter(object sender, EventArgs e)
        {
            if(txt_nuevaCategoria.Text == "Nueva Categoría")
            {
                txt_nuevaCategoria.Text= string.Empty;  
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            Categorias categoria = new Categorias();
            clsArticulos articulo = new clsArticulos();

            marca.descripcion = txt_nuevaMarca.Text;
            categoria.descripcion = txt_nuevaCategoria.Text;
            categoria.id = Convert.ToInt32(dgv_Categoria.CurrentRow.Cells[0].Value);
            marca.id = Convert.ToInt32(dgv_Marcas.CurrentRow.Cells[0].Value);

            if (rb_soloMarca.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txt_nuevaMarca.Text) && txt_nuevaMarca.Text != "Nueva Marca")
                {
                    if (dgv_Marcas.SelectedRows.Count > 0)
                    {
                        articulo.EditarMarca(marca);
                        MessageBox.Show("Marca: " + txt_nuevaMarca.Text + " se ha modificado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: no se admiten campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_soloCategoria.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txt_nuevaCategoria.Text) && txt_nuevaCategoria.Text != "Nueva Categoría")
                {
                    if (dgv_Categoria.SelectedRows.Count > 0)
                    {
                        articulo.EditarCategoria(categoria);
                        MessageBox.Show("Categoría: " + txt_nuevaCategoria.Text + " se ha modificado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: No se admite campo vacío","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (rb_ambas.Checked)
            {
                if ((!string.IsNullOrWhiteSpace(txt_nuevaCategoria.Text) && txt_nuevaCategoria.Text != "Nueva Categoría")
                    && (!string.IsNullOrWhiteSpace(txt_nuevaMarca.Text) && txt_nuevaMarca.Text != "Nueva Marca"))
                {
                    if (dgv_Categoria.SelectedRows.Count > 0 && dgv_Marcas.SelectedRows.Count > 0)
                    {
                        articulo.EditarMarca(marca);
                        articulo.EditarCategoria(categoria);
                        MessageBox.Show("Marca: " + txt_nuevaMarca.Text + "\nCategoría: " + txt_nuevaCategoria.Text + " se han modificado con éxito\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: seleccione fila de marcas y categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: No se admiten campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpiarCampos();
            ListaMarcas();
            ListaCategorias();
        }

        private void eliminarMarca()
        {
            
                Marcas eliminarMarca = new Marcas();
                eliminarMarca.descripcion = dgv_Marcas.CurrentRow.Cells["Descripcion"].Value.ToString();
                eliminarMarca.id = Convert.ToInt32(dgv_Marcas.CurrentRow.Cells[0].Value);
                objArticulo.EliminarMarca(eliminarMarca);
                ListaMarcas();
            

        }
        private void eliminarCategoria()
        {

            Categorias eliminarCategoria = new Categorias();
            eliminarCategoria.descripcion = dgv_Categoria.CurrentRow.Cells["Descripcion"].Value.ToString();
            eliminarCategoria.id = Convert.ToInt32(dgv_Categoria.CurrentRow.Cells[0].Value); // capturo el id de la categoria
            objArticulo.EliminarCategoria(eliminarCategoria);
            ListaCategorias();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (rb_soloMarca.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txt_nuevaMarca.Text) && txt_nuevaMarca.Text != "Nueva Marca")
                {
                    if (dgv_Marcas.SelectedRows.Count > 0)
                    {
                        eliminarMarca();
                        MessageBox.Show("Marca: " + txt_nuevaMarca.Text + " se ha eliminado con éxito","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: El campo de marca no puede estar vacío o contener solo el texto predeterminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_soloCategoria.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txt_nuevaCategoria.Text) && txt_nuevaCategoria.Text != "Nueva Categoría")
                {
                    if (dgv_Categoria.SelectedRows.Count > 0)
                    {
                        eliminarCategoria();
                        MessageBox.Show("Categoría: " + txt_nuevaCategoria.Text + " se ha eliminado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: El campo de categoría no puede estar vacío o contener solo el texto predeterminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_ambas.Checked)
            {
                if ((!string.IsNullOrWhiteSpace(txt_nuevaCategoria.Text) && txt_nuevaCategoria.Text != "Nueva Categoría")
                    && (!string.IsNullOrWhiteSpace(txt_nuevaMarca.Text) && txt_nuevaMarca.Text != "Nueva Marca"))
                {
                    if (dgv_Categoria.SelectedRows.Count > 0 && dgv_Marcas.SelectedRows.Count > 0)
                    {
                        eliminarMarca();
                        eliminarCategoria();
                        MessageBox.Show("Marca: " + txt_nuevaMarca.Text + "\nCategoría: " + txt_nuevaCategoria.Text + " se han eliminado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: seleccione fila de marcas y categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Los campos de marca y categoría no pueden estar vacíos o contener solo el texto predeterminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpiarCampos();
            dgv_Marcas.ClearSelection(); // limpio la selección
            dgv_Categoria.ClearSelection();
        }


        private void rb_soloMarca_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_soloMarca.Checked)
            {
                txt_nuevaMarca.Enabled = true;
                txt_nuevaCategoria.Enabled = false;
            }
            else
            {
                txt_nuevaMarca.Enabled = true; 
            }
        }

        private void rb_soloCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_soloCategoria.Checked)
            {
                txt_nuevaCategoria.Enabled = true;
                txt_nuevaMarca.Enabled = false;
            }
            else
            {
                txt_nuevaMarca.Enabled= true;
            }
        }

        private void rb_ambas_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ambas.Checked)
            {
                txt_nuevaMarca.Enabled = true;
                txt_nuevaCategoria.Enabled = true;
            }
           
        }
    }
}
