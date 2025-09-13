using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Clases
{
    public class BDJson
    {
        public List<persona> personas { get; set; }
        public DateTime UltimaActualizacion { get; set; }
        public int TotalRegistros { get; set; }
        public BDJson()
        {
            personas = new List<persona>();
            UltimaActualizacion = DateTime.Now;
        }
    }
}
