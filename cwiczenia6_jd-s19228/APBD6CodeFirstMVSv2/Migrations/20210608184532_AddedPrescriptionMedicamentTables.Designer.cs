// <auto-generated />
using System;
using APBD6CodeFirstMVSv2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APBD6CodeFirstMVSv2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210608184532_AddedPrescriptionMedicamentTables")]
    partial class AddedPrescriptionMedicamentTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APBD6CodeFirstMVS2.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BirthDate")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPatient")
                        .HasName("Patient_PK");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = 1982,
                            FirstName = "Bogdan",
                            LastName = "Bogusz"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = 1932,
                            FirstName = "Jan",
                            LastName = "Kowal"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = 1945,
                            FirstName = "Kazimierz",
                            LastName = "Lubomirski"
                        },
                        new
                        {
                            IdPatient = 4,
                            BirthDate = 1967,
                            FirstName = "Ludwik",
                            LastName = "Nowakowski"
                        },
                        new
                        {
                            IdPatient = 5,
                            BirthDate = 1980,
                            FirstName = "Marcin",
                            LastName = "Nowak"
                        });
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDoctor")
                        .HasName("Doctor_PK");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "antoni.jazwik@gmiail.com",
                            FirstName = "Antoni",
                            LastName = "Jaźwik"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "kurz.b@onet.pl",
                            FirstName = "Barbara",
                            LastName = "Kurz"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "jadźka@gmiail.com",
                            FirstName = "Jadwiga",
                            LastName = "Jankowska"
                        },
                        new
                        {
                            IdDoctor = 4,
                            Email = "bozenka@buziaczek.onet.pl",
                            FirstName = "Bożena",
                            LastName = "Złotopolska"
                        },
                        new
                        {
                            IdDoctor = 5,
                            Email = "k.krzyz@op.pl",
                            FirstName = "Krzysztof",
                            LastName = "Krzyżowski"
                        });
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMedicament")
                        .HasName("Medicament_PK");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Vaccine 1",
                            Name = "Astra-Zeneca",
                            Type = "Medical experiment"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Vaccine 2",
                            Name = "Sputnik",
                            Type = "Medical experiment"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "Vaccine 3",
                            Name = "Jonson&Jonson",
                            Type = "Medical experiment"
                        },
                        new
                        {
                            IdMedicament = 4,
                            Description = "Vaccine 4",
                            Name = "Moderna",
                            Type = "Medical experiment"
                        },
                        new
                        {
                            IdMedicament = 5,
                            Description = "Vaccine 5",
                            Name = "Pfizer",
                            Type = "Medical experiment"
                        });
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription")
                        .HasName("Pescription_PK");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescription");
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription")
                        .HasName("PescriptionMedicament_PK");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament");
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.Prescription", b =>
                {
                    b.HasOne("APBD6CodeFirstMVSv2.Models.Doctor", "IdDoctorNavigation")
                        .WithMany("Prescriptoins")
                        .HasForeignKey("IdDoctor")
                        .HasConstraintName("Prescription_Patient")
                        .IsRequired();

                    b.HasOne("APBD6CodeFirstMVS2.Models.Patient", "IdPatientNavigation")
                        .WithMany("Prescriptoins")
                        .HasForeignKey("IdPatient")
                        .HasConstraintName("Prescription_Doctor")
                        .IsRequired();

                    b.Navigation("IdDoctorNavigation");

                    b.Navigation("IdPatientNavigation");
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.PrescriptionMedicament", b =>
                {
                    b.HasOne("APBD6CodeFirstMVSv2.Models.Medicament", "IdMedicamentNavigation")
                        .WithMany("PrescriptoinsMedicaments")
                        .HasForeignKey("IdMedicament")
                        .HasConstraintName("PrescriptionMedicament_Medicament")
                        .IsRequired();

                    b.HasOne("APBD6CodeFirstMVSv2.Models.Prescription", "IdPrescriptionNavigation")
                        .WithMany("PrescriptoinsMedicaments")
                        .HasForeignKey("IdPrescription")
                        .HasConstraintName("PrescriptionMedicament_Prescription")
                        .IsRequired();

                    b.Navigation("IdMedicamentNavigation");

                    b.Navigation("IdPrescriptionNavigation");
                });

            modelBuilder.Entity("APBD6CodeFirstMVS2.Models.Patient", b =>
                {
                    b.Navigation("Prescriptoins");
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptoins");
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.Medicament", b =>
                {
                    b.Navigation("PrescriptoinsMedicaments");
                });

            modelBuilder.Entity("APBD6CodeFirstMVSv2.Models.Prescription", b =>
                {
                    b.Navigation("PrescriptoinsMedicaments");
                });
#pragma warning restore 612, 618
        }
    }
}
