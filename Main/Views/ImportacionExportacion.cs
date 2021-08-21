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
        DataTable categorias = new DataTable();
        Consultas consultas = new Consultas();
        public ImportacionExportacion()
        {
            InitializeComponent();

            GetCategorias();
            CargarCategorias(categorias);

        }
        private void GetCategorias()
        {
            categorias = consultas.Query("Select * from categorias");
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string categoria = txt_nombreCategoria.Text;

            var parametros = new List<Parametro>()
            {
                new Parametro() { NombreParametro = "@NOMBRECAT", ValorParametro = categoria }
            };


            bool ok = consultas.Proc("sp_insertCategoria",parametros,true);

            if (ok)
            {

                MessageBox.Show("Datos Guardados Correctamente","Categoria Guardada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetCategorias();
                CargarCategorias(categorias);
                txt_nombreCategoria.Clear();
            }
            else
            {
                MessageBox.Show("Datos No Guardados Correctamente","Categoria NO Guardada",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            
        
        }

        private void CargarCategorias(DataTable categorias)
        {
            dgvCategtorias.DataSource = null;
            dgvCategtorias.DataSource = categorias;
        }
        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            string buscar = txt_busqueda.Text.ToLower();
            var filtrados = categorias.AsEnumerable().Where( categoria =>
           {

               return categoria.Field<string>("Categoria").ToLower().StartsWith(buscar);



           });
            DataTable table = filtrados.AsDataView().ToTable();
            CargarCategorias(table);

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            var excel = new Excel();
            excel.Show();
            this.Hide();
        }
    }
}
