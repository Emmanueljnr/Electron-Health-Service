//using ElectronAPI.Models.Users;
//using Microsoft.EntityFrameworkCore;
//using System;

//namespace ElectronAPI.Context
//{
//    public class ElectronDbContext : DbContext
//    {
//        public class HealthContext : DbContext
//        {
//            public DbSet<Doctor> Doctors { get; set; }
//            public DbSet<Patient> Patients { get; set; }
//            public DbSet<Institution> Institutions { get; set; }
//            public DbSet<Appointment> Appointments { get; set; }

//            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//            //{
//            //    optionsBuilder.UseSqlServer("here's my connection string, how do I add it to the dbContext : \r\nData Source=.\\SQLEXPRESS; Initial Catalog=electron-healthServicesdb;Integrated Security=True; Pooling=False; TrustServerCertificate=True");
//            //}

//            public ElectronDbContext(DbContextOptions<ElectronDbContext> options) : base(options)
//            {

//            }

//            protected override void OnModelCreating(ModelBuilder modelBuilder)
//            {
//                modelBuilder.Entity<Doctor>()
//                    .HasMany(d => d.Patients)
//                    .WithOne(p => p.PrimaryDoctor)
//                    .HasForeignKey(p => p.PrimaryDoctorId);

//                modelBuilder.Entity<Doctor>()
//                    .HasMany(d => d.Institutions)
//                    .WithMany(i => i.Doctors);

//                modelBuilder.Entity<Doctor>()
//                    .HasMany(d => d.Appointments)
//                    .WithOne(a => a.Doctor);

//                modelBuilder.Entity<Patient>()
//                    .HasMany(p => p.Appointments)
//                    .WithOne(a => a.Patient);

//                modelBuilder.Entity<Patient>()
//                    .HasMany(p => p.Institutions)
//                    .WithMany(i => i.Patients);

//                modelBuilder.Entity<Institution>()
//                    .HasMany(i => i.Doctors)
//                    .WithMany(d => d.Institutions);

//                modelBuilder.Entity<Institution>()
//                    .HasMany(i => i.Patients)
//                    .WithMany(p => p.Institutions);

//                modelBuilder.Entity<Institution>()
//                    .HasMany(i => i.Appointments)
//                    .WithOne(a => a.Institution);
//            }
//        }
//    }
//}
