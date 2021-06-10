using APBD6CodeFirstMVSv2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace APBD6CodeFirstMVSv2.Configurations
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public MedicamentEfConfiguration()
        { 
        }
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(k => k.IdMedicament).HasName("Medicament_PK");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Type).IsRequired().HasMaxLength(100);
            
            
            IEnumerable<Medicament> medicaments = new List<Medicament>
            {
                new Medicament{IdMedicament = 1, Name = "Astra-Zeneca", Description = "Vaccine 1", Type = "Medical experiment"},
                new Medicament{IdMedicament = 2, Name = "Sputnik", Description = "Vaccine 2", Type = "Medical experiment"},
                new Medicament{IdMedicament = 3, Name = "Jonson&Jonson", Description = "Vaccine 3", Type = "Medical experiment"},
                new Medicament{IdMedicament = 4, Name = "Moderna", Description = "Vaccine 4", Type = "Medical experiment"},
                new Medicament{IdMedicament = 5, Name = "Pfizer", Description = "Vaccine 5", Type = "Medical experiment"}
            };

            builder.HasData(medicaments);
            
        }
    }
}