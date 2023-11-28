using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.AccessControl;
using Capa_Dominio;
using System.Security.Cryptography;


namespace Capa_persistencia.sqlServer
{
    public class clsArticulos 
    {
        private conexionDB Conexion = new conexionDB();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        private string connectionString = "Server=.\\SQLEXPRESS;Initial Catalog=CATALOGO_DB;Integrated Security=True";
        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM CATEGORIAS ORDER BY Descripcion ASC";
                Comando.CommandType = CommandType.Text;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error al listar categorías: " + ex.Message);
            }
            finally
            {
               
                if (LeerFilas != null && !LeerFilas.IsClosed)
                {
                    LeerFilas.Close();
                }
                Conexion.CerrarConexion();
            }
            return Tabla;
        }

        public DataTable ListarMarcas()
        {
            DataTable Tabla = new DataTable();
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SELECT * FROM MARCAS ORDER BY Descripcion ASC";
                Comando.CommandType = CommandType.Text;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al listar marcas: " + ex.Message);
            }
            finally
            {

                if (LeerFilas != null && !LeerFilas.IsClosed)
                {
                    LeerFilas.Close();
                }
                Conexion.CerrarConexion();
            }
            return Tabla;
        }
        public void InsertarArticulos(infoArticulos nuevoArticulo)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio)" +
                    "VALUES(@codigo,@nombre,@desc,@idMarca,@idcat,@imagen,@prec)";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@codigo", nuevoArticulo.codigoArticulo);
                Comando.Parameters.AddWithValue("@nombre", nuevoArticulo.nombreArticulo);
                Comando.Parameters.AddWithValue("@desc", nuevoArticulo.descripcionArticulo);
                Comando.Parameters.AddWithValue("@idMarca", nuevoArticulo.TipoMarca.id);
                Comando.Parameters.AddWithValue("@idcat", nuevoArticulo.TipoCat.id);
                Comando.Parameters.AddWithValue("@imagen", nuevoArticulo.imagenArticulo);
                Comando.Parameters.AddWithValue("@prec", nuevoArticulo.precio);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }catch(Exception ex)
            {
                Console.WriteLine("Error al insertar un artículo: " + ex.Message);
            }
            finally
            {
            Conexion.CerrarConexion();
            }
        }
        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = @"SELECT 
                                    A.Codigo, 
                                    A.Nombre, 
                                    A.Descripcion AS DescripcionArticulo,
                                    (SELECT Descripcion FROM MARCAS WHERE ID = A.IdMarca) AS MARCA,
                                    (SELECT Descripcion FROM CATEGORIAS WHERE Id = A.idCategoria) AS Categoria,
                                    A.Precio,
                                    A.ImagenUrl
                                FROM 
                                    ARTICULOS A";
                Comando.CommandType = CommandType.Text;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar artículos : " + ex.Message);
            }
            finally
            {
                if (LeerFilas != null && !LeerFilas.IsClosed)
                {
                    LeerFilas.Close();
                }
                Conexion.CerrarConexion();
            }
            return Tabla;
        }


        // editar y eliminar

        public void EditarArticulo(infoArticulos articulos)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE ARTICULOS SET IdCategoria=@IdCategoria, IdMarca=@IdMarca, Descripcion=@Descripcion, Precio=@Precio, ImagenUrl=@ImagenUrl, Nombre=@Nombre WHERE Codigo=@Codigo";

                Comando.Parameters.AddWithValue("@IdCategoria", articulos.TipoCat.id);
                Comando.Parameters.AddWithValue("@IdMarca", articulos.TipoMarca.id);
                Comando.Parameters.AddWithValue("@Descripcion", articulos.descripcionArticulo);
                Comando.Parameters.AddWithValue("@Precio", articulos.precio);
                Comando.Parameters.AddWithValue("@ImagenUrl", articulos.imagenArticulo);
                Comando.Parameters.AddWithValue("@Nombre", articulos.nombreArticulo);
                Comando.Parameters.AddWithValue("@Codigo", articulos.codigoArticulo);
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar editar el artículo: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        public void EliminarArticulos(infoArticulos elim)
        {
            try
            {
               

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "DELETE FROM ARTICULOS WHERE Codigo = @codigo";
                        command.Parameters.AddWithValue("@codigo",elim.codigoArticulo);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void EliminarMarca(Marcas elim)
        {
            try
            {
                

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "DELETE FROM MARCAS WHERE Descripcion = @desc AND Id = @id";
                        command.Parameters.AddWithValue("@desc", elim.descripcion);
                        command.Parameters.AddWithValue("@id", elim.id);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void EliminarCategoria(Categorias elim)
        {
            try
            {
                

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "DELETE FROM CATEGORIAS WHERE Descripcion = @desc AND Id = @id";
                        command.Parameters.AddWithValue("@desc", elim.descripcion);
                        command.Parameters.AddWithValue("@id", elim.id);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------
        //Agregar categorias y marcas
        public void InsertarMarcas(Marcas nuevaMarca)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "INSERT INTO MARCAS(Descripcion) VALUES(@Desc)";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@Desc", nuevaMarca.descripcion);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar marca: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        public void InsertarCategorias(Categorias nuevaCategoria)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "INSERT INTO CATEGORIAS (Descripcion) VALUES(@Desc)";
                Comando.CommandType = CommandType.Text;
                Comando.Parameters.AddWithValue("@Desc", nuevaCategoria.descripcion);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar categoría: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }



        public void EditarMarca(Marcas marca)
        {

            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE MARCAS SET Descripcion = @desc  WHERE Id = @id";
                Comando.Parameters.AddWithValue("@Id", marca.id);
                Comando.Parameters.AddWithValue("@desc", marca.descripcion);
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
               
            }catch(Exception ex)
            {
                Console.WriteLine("Error al editar Marca: "+ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }


        }
        public void EditarCategoria(Categorias categorias)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "UPDATE CATEGORIAS SET Descripcion = @desc  WHERE Id = @idcat";
                Comando.Parameters.AddWithValue("@Idcat", categorias.id);
                Comando.Parameters.AddWithValue("@desc", categorias.descripcion);
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
            }catch(Exception ex)
            {
                Console.WriteLine("Error al editar categoría: " + ex.Message);
            }
            finally
            {
                Comando.Connection = Conexion.CerrarConexion();
            }

        }




        //--------------------Busqueda de articulos

        public DataTable ListarPorNombre(infoArticulos articulo)
        {
            DataTable Tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                A.Codigo, 
                                A.Nombre, 
                                A.Descripcion AS DescripcionArticulo,
                                (SELECT Descripcion FROM MARCAS WHERE ID = A.IdMarca) AS MARCA,
                                (SELECT Descripcion FROM CATEGORIAS WHERE Id = A.idCategoria) AS Categoria,
                                A.Precio,
                                A.ImagenUrl
                            FROM 
                                ARTICULOS A
                            WHERE 
                                A.Nombre LIKE @nombreArticulo + '%'";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombreArticulo", articulo.nombreArticulo);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Tabla.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                throw new Exception("Error al ejecutar la consulta SQL");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Error inesperado");
            }

            return Tabla;
        }

        // bisqueda para precio minimo
        public DataTable ListarPorPrecioMin(decimal pMin)
        {
            DataTable Tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                A.Codigo, 
                                A.Nombre, 
                                A.Descripcion AS DescripcionArticulo,
                                (SELECT Descripcion FROM MARCAS WHERE ID = A.IdMarca) AS MARCA,
                                (SELECT Descripcion FROM CATEGORIAS WHERE Id = A.idCategoria) AS Categoria,
                                A.Precio,
                                A.ImagenUrl
                            FROM 
                                ARTICULOS A
                            WHERE 
                                A.Precio >= @precioMin";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@precioMin", pMin);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Tabla.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                throw new Exception("Error al ejecutar la consulta SQL");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Error inesperado");
            }

            return Tabla;
        }

        public DataTable ListarPorPrecioMax(decimal pMax)
        {
            DataTable Tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                A.Codigo, 
                                A.Nombre, 
                                A.Descripcion AS DescripcionArticulo,
                                (SELECT Descripcion FROM MARCAS WHERE ID = A.IdMarca) AS MARCA,
                                (SELECT Descripcion FROM CATEGORIAS WHERE Id = A.idCategoria) AS Categoria,
                                A.Precio,
                                A.ImagenUrl
                            FROM 
                                ARTICULOS A
                            WHERE 
                                A.Precio <= @precioMax";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@precioMax", pMax);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Tabla.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                throw new Exception("Error al ejecutar la consulta SQL");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Error inesperado");
            }

            return Tabla;
        }

        public DataTable ListarPorRangoPrecio(decimal pMin, decimal pMax)
        {
            DataTable Tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                A.Codigo, 
                                A.Nombre, 
                                A.Descripcion AS DescripcionArticulo,
                                (SELECT Descripcion FROM MARCAS WHERE ID = A.IdMarca) AS MARCA,
                                (SELECT Descripcion FROM CATEGORIAS WHERE Id = A.idCategoria) AS Categoria,
                                A.Precio,
                                A.ImagenUrl
                            FROM 
                                ARTICULOS A
                            WHERE 
                                A.Precio BETWEEN @precioMin AND @precioMax";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@precioMin", pMin);
                        cmd.Parameters.AddWithValue("@precioMax", pMax);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Tabla.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                throw new Exception("Error al ejecutar la consulta SQL");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Error inesperado");
            }

            return Tabla;
        }


        //---- funcion para retornar el precio maximo de los articulos 
        public decimal ObtenerPrecioMaximo()
        {
            decimal precioMaximo = decimal.MinValue;

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Precio) AS precioMaximo FROM ARTICULOS";   

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        precioMaximo = Convert.ToDecimal(result);
                    }
                }
            }

            return precioMaximo;
        }
        public decimal ObtenerPrecioMinimo()
        {
            decimal precioMinimo = decimal.MaxValue;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MIN(Precio) AS precioMinimo FROM ARTICULOS";  

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        precioMinimo = Convert.ToDecimal(result);
                    }
                }
            }

            return precioMinimo;
        }
       //--------------------------- validadores de marca categoria y codigo
        public int existeMarca(string descripcion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string consulta = "SELECT COUNT(Descripcion) FROM MARCAS WHERE Descripcion = @desc";
                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@desc", descripcion);
                        int i = Convert.ToInt32(comando.ExecuteScalar());
                        return i;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int existeCategoria(string descripcion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string consulta = "SELECT COUNT(Descripcion) FROM CATEGORIAS WHERE Descripcion = @desc";
                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@desc", descripcion);
                        int i = Convert.ToInt32(comando.ExecuteScalar());
                        return i;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int existeCodigo(string codigo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string consulta = "SELECT COUNT(Codigo) FROM ARTICULOS WHERE Codigo = @codigo";
                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigo);
                        int i = Convert.ToInt32(comando.ExecuteScalar());
                        return i;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //------------------------------------------------------------------------------------------------------
    }
}
