using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_V_1.Entities
{
    public class AlumnoObservaciones
    {
        public int Id { get; set; }
        public virtual Alumno AlumnoId { get; set; }
        public virtual Observaciones ObservacionesId { get; set; }
        public string Observacion { get; set; }
    }
}
