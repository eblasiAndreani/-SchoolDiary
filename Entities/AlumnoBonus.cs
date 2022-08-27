using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_V_1.Entities
{
    public class AlumnoBonus
    {
        public int Id { get; set; }
        public virtual Alumno AlumnoId { get; set; }
        public virtual Bonus BonusId { get; set; }
        public decimal Calificacion { get; set; }
    }
}
