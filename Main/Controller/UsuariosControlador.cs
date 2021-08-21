using Dapper;
using Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Controller
{
    public class UsuariosControlador:DBConexion
    {
        private string sql = @"
            Select * from usuarios
            where NombreUsuario=@NombreUsuario
            and Clave=@Clave
            ";

        public Usuarios Login(string NombreUsuario, string Clave)
        {
            using (var db = GetConexion)
            {

                var res = db.Query<Usuarios>(sql,new { NombreUsuario,  Clave });
                Usuarios usuario = new Usuarios();
                if (res.Count() > 0)
                {
                    usuario = res.First();

                }
                
                return usuario;
            }
        }



    }
}
