using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class MedDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Perscription> Prescriptions { get; set; }
        
        public DbSet<PerscriptionMedicament> Perscription_Medicaments { get; set; }

        public MedDbContext()
        {

        }
        public MedDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PerscriptionMedicament>()
           .HasKey(e => new { e.IdMedicament, e.IdPrescription });

            seed(modelBuilder);
        }

        public void seed(ModelBuilder model)
        {
            var doctors = new List<Doctor>();
            doctors.Add(new Doctor{
                IdDoctor = 1,
                FirstName = "Paweł",
                LastName = "Pietrzak",
                Email = "pp31@gmail.com"
            });


            doctors.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "Andrzej",
                LastName = "Rzepka",
                Email = "rzepa@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 3,
                FirstName = "Joanna",
                LastName = "Koch",
                Email = "kkocha@gmail.com"
            });

            model.Entity<Doctor>().HasData(doctors);

            var patients = new List<Patient>();

            patients.Add(new Patient
            {
                IdPatient = 1,
                FirstName = "karol",
                LastName = "Kowalski",
                Birthday = DateTime.Parse("1988-10-01")
            });

            patients.Add(new Patient
            {
                IdPatient = 2,
                FirstName = "Jakub",
                LastName = "Jakubowski",
                Birthday = DateTime.Parse("1996-07-02")
            });

            patients.Add(new Patient
            {
                IdPatient = 3,
                FirstName = "Paulina",
                LastName = "Jakubowski",
                Birthday = DateTime.Parse("2000-07-02")
            });


            patients.Add(new Patient
            {
                IdPatient = 4,
                FirstName = "Piotr",
                LastName = "Wichura",
                Birthday = DateTime.Parse("1946-07-02")
            });

            model.Entity<Patient>().HasData(patients);

            var medicaments = new List<Medicament>();

            medicaments.Add(new Medicament
            {
                IdMedicament = 1,
                Name = "Aspirin",
                Description = "Lek na stany gorączkowe, obnizona odp",
                Type = "Pastylki",
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 2,
                Name = "Ibuprom",
                Description = "Na Przeziębienie, ból głowy",
                Type = "Tabletka",
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 3,
                Name = "Desmoxan",
                Description = "Rzucanie Palenia",
                Type = "Plaster",
            });

            model.Entity<Medicament>().HasData(medicaments);

            var prescriptions = new List<Perscription>();

            prescriptions.Add(new Perscription
            {
                IdPrescription = 1,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddMonths(4),
                IdPatient = 1,
                IdDoctor = 1

            });

            prescriptions.Add(new Perscription
            {
                IdPrescription = 2,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddMonths(4),
                IdPatient = 2,
                IdDoctor = 1
            });

            model.Entity<Perscription>().HasData(prescriptions);

            var perscriptions_medicaments = new List<PerscriptionMedicament>();

            perscriptions_medicaments.Add(new PerscriptionMedicament
            {
                IdPrescription = 1,
                IdMedicament = 1,
                Dose = 5,
                Details = "5 razy dziennie przed posilkiem"
            });

            perscriptions_medicaments.Add(new PerscriptionMedicament
            {
                IdPrescription = 2,
                IdMedicament = 2,
                Dose=2,
                Details = "30 min przed zasnieciem 2 porcje"
            });

            model.Entity<PerscriptionMedicament>().HasData(perscriptions_medicaments);
        }

    }
}
