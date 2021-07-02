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
    public partial class InicioSesion : Form
    {
        UsuariosControlador uControlador = new UsuariosControlador();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            var user = txt_user.Text; 
            var password = txt_clave.Text;

            Usuarios usuario = uControlador.Login(user, password);
            if (usuario.NombreUsuario == null)
            {
                MessageBox.Show("El nombre de usuario o la contraseña no son correctos", "Credenciales incorrectas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                var importexport = new ImportacionExportacion();
                importexport.Show();
                this.Hide();
                usuario = new Usuarios();

            }
        }
    }
}
