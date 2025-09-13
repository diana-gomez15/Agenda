using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Clases
{
    public class persona
    {
        public string nombre { get; set; }
        public string apPat { get; set; }
        public string apMat { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }

        public persona()
        {

        }

        public persona(string nombre,string apPat, string apMat, string direccion, string telefono, string correo)
        {
            this.nombre = nombre;
            this.apPat = apPat;
            this.apMat = apMat;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
