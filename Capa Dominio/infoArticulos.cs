using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Capa_Dominio
{
    public class infoArticulos
    {
        public int id_Articulo {  get; set; }     // primary key de tabla articulos
        public string codigoArticulo { get; set; }  
        public string nombreArticulo { get; set; }  
        public string descripcionArticulo { get; set;}

        public Marcas TipoMarca { get; set; }
        public Categorias TipoCat {  get; set; }
        public string imagenArticulo { get; set; }  
        public decimal precio { get; set; }

       


    }
}
