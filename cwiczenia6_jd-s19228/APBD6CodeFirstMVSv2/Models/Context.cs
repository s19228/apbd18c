using APBD6CodeFirstMVS2.Models;
using APBD6CodeFirstMVSv2.Configurations;
using Microsoft.EntityFrameworkCore;

namespace APBD6CodeFirstMVSv2.Models
{
    public class Context : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
        protected Context()
        { 
        
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorEfConfiguration());
            modelBuilder.ApplyConfiguration(new PatientEfConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionEfConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionMedicamentEfConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentEfConfiguration());
        }
    }
}
