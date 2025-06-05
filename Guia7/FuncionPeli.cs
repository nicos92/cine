using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia7
{
    public class FuncionPeli
    {
        public Pelicula LaPelicula { get; set; }
        public string Sala { get; set; }
        public string Fecha { get; set; }
        public string Horario { get; set; }

        public List<string> asientos = new List<string>();

       public string codigoCompra { get; set; }
    }
}
