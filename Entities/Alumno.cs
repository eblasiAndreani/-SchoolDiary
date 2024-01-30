using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_V_1.Entities
{
    public class Alumno
    {
        public int Id { get; set; }
        public virtual Curso CursoId { get; set; }
        public string ApellidoNombres { get; set; }
        public string Apodo { get; set; }
        public string Telefono { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public decimal Promedio { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
        public virtual ICollection<AlumnoEvaluacion> AlumnoEvaluacion { get; set; }
        public virtual ICollection<AlumnoPeriodo> AlumnoPeriodo { get; set; }
        public virtual ICollection<AlumnoBonus> AlumnoBonus { get; set; }
        public virtual ICollection<AlumnoObservaciones> AlumnoObservaciones { get; set; }
    }
}