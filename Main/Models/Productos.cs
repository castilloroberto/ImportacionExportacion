using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Existencias { get; set; }
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public int IdMarca { get; set; }
        public string Marca { get; set; }
        public int IdProveedor { get; set; }
        public string Proveedor { get; set; }

        public bool Estado { get; set; }


        public Productos()
        {
            Estado = true;
        }

    }
}
