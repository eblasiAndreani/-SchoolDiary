using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_V_1.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public int Anio { get; set; }
        public string Seccion { get; set; }
        public string Turno { get; set; }
        public string Escuela { get; set; }
        public virtual ICollection<Recordatorio> Recordatorio { get; set; }
        public virtual ICollection<Alumno> Alumno { get; set; }

    }
}
