using Dapper;
using Main.Controller;
using Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class ProductosController:DBConexion
    {


        public IEnumerable<Productos> GetProductos()
        {
            using (var db = GetConexion)
            {

                return db.Query<Productos>("sp_productos");
            }
        }

    }
}
