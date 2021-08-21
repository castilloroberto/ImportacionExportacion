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

namespace Main.Views
{
    public partial class Usuarios : Form
    {
        Consultas consultas = new Consultas();
        DataTable usuarios = new DataTable(); 
        public Usuarios()
        {
            InitializeComponent();
            usuarios = consultas.Query("select * from usuarios");
        }
    }
}
