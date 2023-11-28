using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Capa_persistencia.sqlServer
{
    public class conexionDB
    {
        static private string connetionString = "Server=.\\SQLEXPRESS;Initial Catalog=CATALOGO_DB;Integrated Security=True";

        private SqlConnection Conexion = new SqlConnection(connetionString);
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
