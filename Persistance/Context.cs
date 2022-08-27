using Microsoft.EntityFrameworkCore;
using School_V_1.Entities;
using System.Reflection;

namespace School_V_1.Persistance
{
    public class Context : DbContext
    {
        static readonly string database = "dbSqlite.db";
        public DbSet<Entities.Alumno> Alumno { get; set; }
        public DbSet<AlumnoBonus> AlumnoBonus { get; set; }
        public DbSet<AlumnoEvaluacion> AlumnoEvaluacion { get; set; }
        public DbSet<AlumnoObservaciones> AlumnoObservaciones { get; set; }
        public DbSet<AlumnoPeriodo> AlumnoPeriodo { get; set; }
        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<DiaNoLaborable> DiaNoLaborable { get; set; }
        public DbSet<EstadoAsistencia> EstadoAsistencia { get; set; }
        public DbSet<Evaluacion> Evaluacion { get; set; }
        public DbSet<Observaciones> Observaciones { get; set; }
        public DbSet<Periodo> Periodo { get; set; }
        public DbSet<Recordatorio> Recordatorio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Filename=" + database,
                sqliteOptionsAction: op =>
                {
                    op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

