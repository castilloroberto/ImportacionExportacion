using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Necesario


namespace Main
{
    public class Conexion
    {
        //protected SqlConnection conexion = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SistemasIDB;Trusted_Connection=True;");


        //public bool Modificacion(string sql)
        //{
        //    SqlCommand command = new SqlCommand(sql,conexion);
        //    conexion.Open();
            
        //    command.ExecuteNonQuery();
        //    //conexion.Dispose();
        //    command.Dispose();

        //    //conexion.Close();
            
        //    return true;
        //}

        //public void Busqueda(string sql,DataGridView datagrid,string columna)
        //{

        //    DataSet dataSet = new DataSet();

        //    BindingSource bindingSource = new BindingSource();

        //    DataTable dataTable = new DataTable();

        //    conexion.Open();
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql,conexion);

        //    dataAdapter.Fill(dataTable);

        //    bindingSource.DataSource = dataTable.DefaultView;
        //    datagrid.DataSource = bindingSource;
           
        //    DataSet dataSet2 = new DataSet();
        //    dataSet2.Tables.Add(dataTable.Copy());

        //    DataView dataView = new DataView(dataSet2.Tables[0]);

        //    dataView.RowFilter = columna;
        //    if (dataView.Count != 0 )
        //    {
        //        datagrid.DataSource = dataView;
        //    }
        //    else
        //    {
        //        datagrid.DataSource = null;

        //    }

            
        //}
        //public DataSet Consultas(string sql)
        //{
        //    DataSet dataSet;
        //    DataSet dataSet2 = new DataSet();

        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,conexion);
        //    sqlDataAdapter.Fill(dataSet2, "Tabla");

        //    dataSet = dataSet2;


        //    dataSet.Dispose();
        //    dataSet2.Dispose();

        //    return dataSet;

        //}

    }
}
