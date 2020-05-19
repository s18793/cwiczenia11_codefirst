﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cw11.Models;

namespace cw11.Migrations
{
    [DbContext(typeof(MedDbContext))]
    partial class MedDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cw11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "pp31@gmail.com",
                            FirstName = "Paweł",
                            LastName = "Pietrzak"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "rzepa@gmail.com",
                            FirstName = "Andrzej",
                            LastName = "Rzepka"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "kkocha@gmail.com",
                            FirstName = "Joanna",
                            LastName = "Koch"
                        });
                });

            modelBuilder.Entity("cw11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Lek na stany gorączkowe, obnizona odp",
                            Name = "Aspirin",
                            Type = "Pastylki"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Na Przeziębienie, ból głowy",
                            Name = "Ibuprom",
                            Type = "Tabletka"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "Rzucanie Palenia",
                            Name = "Desmoxan",
                            Type = "Plaster"
                        });
                });

            modelBuilder.Entity("cw11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            Birthday = new DateTime(1988, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "karol",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdPatient = 2,
                            Birthday = new DateTime(1996, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jakub",
                            LastName = "Jakubowski"
                        },
                        new
                        {
                            IdPatient = 3,
                            Birthday = new DateTime(2000, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Paulina",
                            LastName = "Jakubowski"
                        },
                        new
                        {
                            IdPatient = 4,
                            Birthday = new DateTime(1946, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Piotr",
                            LastName = "Wichura"
                        });
                });

            modelBuilder.Entity("cw11.Models.Perscription", b =>
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

                    b.HasKey("IdPrescription");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 5, 19, 18, 15, 22, 45, DateTimeKind.Local).AddTicks(6213),
                            DueDate = new DateTime(2020, 9, 19, 18, 15, 22, 52, DateTimeKind.Local).AddTicks(1865),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2020, 5, 19, 18, 15, 22, 52, DateTimeKind.Local).AddTicks(3291),
                            DueDate = new DateTime(2020, 9, 19, 18, 15, 22, 52, DateTimeKind.Local).AddTicks(3322),
                            IdDoctor = 1,
                            IdPatient = 2
                        });
                });

            modelBuilder.Entity("cw11.Models.PerscriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.ToTable("Perscription_Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 1,
                            Details = "5 razy dziennie przed posilkiem",
                            Dose = 5
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 2,
                            Details = "30 min przed zasnieciem 2 porcje",
                            Dose = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
