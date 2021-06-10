using APBD6CodeFirstMVSv2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace APBD6CodeFirstMVSv2.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public DoctorEfConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(k => k.IdDoctor).HasName("Doctor_PK");
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Email).HasMaxLength(100);
            

            IEnumerable<Doctor> doctors = new List<Doctor>
            {
                new Doctor{IdDoctor = 1, FirstName = "Antoni", LastName = "Jaźwik", Email = "antoni.jazwik@gmiail.com"},
                new Doctor{IdDoctor = 2, FirstName = "Barbara", LastName = "Kurz", Email = "kurz.b@onet.pl"},
                new Doctor{IdDoctor = 3, FirstName = "Jadwiga", LastName = "Jankowska", Email = "jadźka@gmiail.com"},
                new Doctor{IdDoctor = 4, FirstName = "Bożena", LastName = "Złotopolska", Email = "bozenka@buziaczek.onet.pl"},
                new Doctor{IdDoctor = 5, FirstName = "Krzysztof", LastName = "Krzyżowski", Email = "k.krzyz@op.pl"}
            };
            
            builder.HasData(doctors);
            
        }
    }
}
