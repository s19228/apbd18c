using APBD6CodeFirstMVSv2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD6CodeFirstMVSv2.Configurations
{
    public class PrescriptionMedicamentEfConfiguration : IEntityTypeConfiguration<PrescriptionMedicament>
    {
        public PrescriptionMedicamentEfConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
        {
            builder.HasKey(k => new {k.IdMedicament, k.IdPrescription}).HasName("PescriptionMedicament_PK");
            builder.Property(p => p.Dose);
            builder.Property(p => p.Details).IsRequired().HasMaxLength(100);
            
            
            builder.HasOne(d => d.IdMedicamentNavigation)
                .WithMany(p => p.PrescriptoinsMedicaments)
                .HasForeignKey(d => d.IdMedicament)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PrescriptionMedicament_Medicament");
            
            builder.HasOne(d => d.IdPrescriptionNavigation)
                .WithMany(p => p.PrescriptoinsMedicaments)
                .HasForeignKey(d => d.IdPrescription)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PrescriptionMedicament_Prescription"); ;
            
            builder.ToTable("Prescription_Medicament");
        }
    }
}