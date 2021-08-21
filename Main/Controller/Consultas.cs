using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Controller
{
    public class Consultas:DBConexion
    {
        public DataTable Query(string sql)
        {
            using (var conexion = GetConexion)
            {
                conexion.Open();

                // select
                DataTable dataTable = new DataTable();

                SqlCommand query = new SqlCommand(sql, conexion);
                
                
                // select
                SqlDataReader dataReader = query.ExecuteReader();
                
                dataTable.Load(dataReader);
                
                dataReader.Close();
                conexion.Close();
                
                return dataTable;

            }
        }


        public dynamic Proc(string NombreProc, List<Parametro> parametros,bool modificacion)
        {
            
            using (var conexion = GetConexion)
            {
                conexion.Open();

                SqlCommand command = new SqlCommand(NombreProc, conexion);
                command.CommandType = CommandType.StoredProcedure;

                foreach (Parametro parametro in parametros)
                {

                    command.Parameters.AddWithValue(parametro.NombreParametro, parametro.ValorParametro);

                }

                if (modificacion)
                {
                   var resultado = command.ExecuteNonQuery();

                   conexion.Close();
                   return resultado > 0;
                }
                else
                {
                    SqlDataReader reader = command.ExecuteReader();
                    var resultado = new DataTable();

                    resultado.Load(reader);
                    reader.Close();
                    conexion.Close();
                    
                    return resultado;
                }



            }
        }

    }
}
