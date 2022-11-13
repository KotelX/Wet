
using Microsoft.EntityFrameworkCore;
using Wet.Models;

namespace Wet
{
    public class WetContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Symptom> Simptoms { get; set; }
        public DbSet<Diagnosis> Diagnozs { get; set; }
        public WetContext(DbContextOptions<WetContext> options)
        : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        public WetContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source = wpl36.hosting.reg.ru; Database = u1495960_LSBBot; Integrated Security = False; User ID = u1495960_u1495960; Password = NUpDe10sVk57QbSf;");
                optionsBuilder.UseSqlServer("Data Source = wpl36.hosting.reg.ru; Database = u1495960_Vvet; Integrated Security = True; User ID = u1495960_vvet; Password = G!x4x3x35;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                    new Patient()
                    {
                        Name = "Cat"
                    }
            );
        }
    }
}