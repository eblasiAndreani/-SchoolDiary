using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_V_1.Entities
{
    public class Recordatorio
    {
        public int Id { get; set; }
        public virtual Curso CursoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public bool? Activo { get; set; }
    }
}
