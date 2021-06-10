using APBD6CodeFirstMVSv2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD6CodeFirstMVSv2.Configurations
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public PrescriptionEfConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(k => k.IdPrescription).HasName("Pescription_PK");
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.DueDate).IsRequired();
            
            builder.HasOne(d => d.IdDoctorNavigation)
                .WithMany(p => p.Prescriptoins)
                .HasForeignKey(d => d.IdDoctor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prescription_Patient");

             builder.HasOne(d => d.IdPatientNavigation)
                 .WithMany(p => p.Prescriptoins)
                 .HasForeignKey(d => d.IdPatient)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("Prescription_Doctor");

            builder.ToTable("Prescription");

        }
    }
}