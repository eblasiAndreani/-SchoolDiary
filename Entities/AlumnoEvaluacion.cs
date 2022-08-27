using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_V_1.Entities
{
    public class AlumnoEvaluacion
    {
        public int Id { get; set; }
        public virtual Alumno AlumnoId { get; set; }
        public virtual Evaluacion EvaluacionId { get; set; }
        public decimal Calificacion { get; set; }
    }
}
