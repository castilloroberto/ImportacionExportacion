using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Controller
{
    public class DBConexion
    {
        private static string server = "localhost\\SQLEXPRESS";
        private string cadena = $"Server={server};Database=SistemasIDB;Trusted_Connection=True;";
        protected SqlConnection GetConexion => new SqlConnection(cadena);

    }
}
