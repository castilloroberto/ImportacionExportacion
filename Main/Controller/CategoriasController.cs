using Dapper;
using Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Controller
{
    public class CategoriasController:DBConexion
    {
        public IEnumerable<Categorias> GetCategorias()
        {
            using (var db = GetConexion)
            {
                return db.Query<Categorias>("Select * from categorias");
            }
        }

        public bool InsertCategoria(string categoria)
        {
            using (var db = GetConexion)
            {
                return db.Execute("sp_insertCategoria @NOMBRECAT", new { NOMBRECAT=categoria }) > 0;
            }
        }
    }
}
