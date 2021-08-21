using ClosedXML.Excel;
using Main.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Spire;

namespace ImportacionExportacion
{
    public partial class Excel : Form
    {
        Consultas consultas = new Consultas();
        DataTable consulta = new DataTable();
        public Excel()
        {
            InitializeComponent();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {

            consulta = consultas.Query(txt_query.Text);
            dgv_datos.DataSource = consulta;
        }

        private void btn_guardar_archivo_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx"
            };
            

            var res = saveFile.ShowDialog();
            if ( res == DialogResult.OK)
            {
                string fileName = saveFile.FileName;
                try
                {

                    XLWorkbook workbook = new XLWorkbook();
                        
                    workbook.Worksheets.Add(consulta,"pagina1");
                    workbook.SaveAs(fileName);
                        
                    MessageBox.Show($"El archivo se guardo con exito\nEl archivo se guardo en: {fileName}", "Archivo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception error)
                {

                    MessageBox.Show($"Algo Salio mal:\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            








            //string fileName;
            //Spire.DataExport.XLS.CellExport cellExport = new Spire.DataExport.XLS.CellExport();
            //Spire.DataExport.XLS.WorkSheet workSheet = new Spire.DataExport.XLS.WorkSheet();

            //workSheet.dataSource = Spire.DataExport.Common.ExportSource.DataTable;
            //workSheet.DataTable = dgv_datos.DataSource as DataTable;
            //workSheet.StartDataCol = (System.Byte(0));


            //cellExport.Sheets.Add(workSheet);
            //cellExport.ActionAfterExport = spire.dataExporty.Common.ActionType.OpenView;

            //fileName = txt_nombre_archivoExportar.Text.ToLower()+".xls";
            //cellExport.SaveToFile(fileName);

        }

        private void btn_volver_insersion_Click(object sender, EventArgs e)
        {
            var insersion = new ImportacionExportacion();
            insersion.Show();
            this.Hide();
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {



            //string fileName = txt_archivo_importar.Text;

            //Spire.Xls.Workbook workBook = new Spire.Xls.Workbook();

            //workBook.LoadFromFile(fileName);

            //Spire.Xls.WorkSheet sheet = workBook.WorkSheets[0];

            //dgv_datos.DataSource = null;
            //dgv_datos.DataSource = sheet.ExportDataTable();




            
        }

        private void btn_guardar_db_Click(object sender, EventArgs e)
        {
            
        }
    }
}
