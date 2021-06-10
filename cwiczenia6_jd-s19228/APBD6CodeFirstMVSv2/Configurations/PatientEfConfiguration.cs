using System.Collections.Generic;
using APBD6CodeFirstMVS2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD6CodeFirstMVSv2.Configurations
{
    public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        public PatientEfConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(k => k.IdPatient).HasName("Patient_PK");
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(100);
            builder.Property((p => p.BirthDate)).IsRequired();
                
            //uzupełnianie zawartości w trakcie tworzenia 
            
             IEnumerable<Patient> patients = new List<Patient>
            {
                new Patient{IdPatient = 1, FirstName = "Bogdan", LastName = "Bogusz", BirthDate = 1982},
                new Patient{IdPatient = 2, FirstName = "Jan", LastName = "Kowal", BirthDate = 1932},
                new Patient{IdPatient = 3, FirstName = "Kazimierz", LastName = "Lubomirski", BirthDate = 1945},
                new Patient{IdPatient = 4, FirstName = "Ludwik", LastName = "Nowakowski", BirthDate = 1967},
                new Patient{IdPatient = 5, FirstName = "Marcin", LastName = "Nowak", BirthDate = 1980}
            };

            builder.HasData(patients);

        }
    }
}