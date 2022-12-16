using Microsoft.EntityFrameworkCore;
using Wet.Models;

namespace Wet
{
    public class WetContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Visiting> Visits { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Symptom> Simptoms { get; set; }
        public DbSet<Diagnosis> Diagnozs { get; set; }
        public WetContext(DbContextOptions<WetContext> options)
        : base(options)
        {
            //Database.EnsureCreated();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Patient>().HasData(
        //            new Patient()
        //            {
        //                Name = "Cat"
        //            }
        //    );
        //}
    }
}