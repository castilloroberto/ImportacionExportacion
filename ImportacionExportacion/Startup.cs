using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportacionExportacion
{
    public class Startup
    {
        public static void Main()
        {
            var main = new InicioSesion();
            Application.Run(main);
        }
    }
}
