using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_V_1.Entities
{
    public class EstadoAsistencia
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
    }
}
