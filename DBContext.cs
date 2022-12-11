﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Wet.Models;

namespace Wet
{
    public class WetContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Symptom> Simptoms { get; set; }
        public DbSet<Diagnosis> Diagnozs { get; set; }
        public WetContext(DbContextOptions<WetContext> options)
        : base(options)
        {
            Database.EnsureCreated();
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