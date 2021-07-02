using Main;
using Main.Controller;
using Main.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportacionExportacion
{
    public partial class ImportacionExportacion : Form
    {
        ProductosController produController = new ProductosController();
        CategoriasController categController = new CategoriasController();
        List<Productos> productos;
        public ImportacionExportacion()
        {
            InitializeComponent();
            productos = produController.GetProductos().ToList();
            CargarProductos(productos);
            CargarCategorias();

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string categoria = txt_nombreCategoria.Text;

            bool ok = categController.InsertCategoria(categoria);
            
            if(ok)
                MessageBox.Show("Datos Guardados Correctamente","Categoria Guardada",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txt_nombreCategoria.Clear();
            CargarCategorias();
        
        }
        private void CargarCategorias()
        {
            cb_categorias.DataSource = null;
            cb_categorias.DataSource = categController.GetCategorias();

            cb_categorias.DisplayMember = "Categoria";
            cb_categorias.ValueMember = "Id";

            
        }
        private void CargarProductos(List<Productos> pts)
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = pts;
        }
        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            string buscar = txt_busqueda.Text;
            List<Productos> filtrados = productos.Where<Productos>(p => {

                return p.Producto.ToLower().StartsWith(buscar) || p.CodigoProducto.ToLower().StartsWith(buscar);


            }).ToList();
            CargarProductos(filtrados);

        }
    }
}
