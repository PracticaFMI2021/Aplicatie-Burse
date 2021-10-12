
using Clinic_Management_Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Clinic_Management_Application.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // public DbSet<Patient> Patients { get; set; }
        // public DbSet<PatientSettings> PatientsSettings{get;set;}
        // public DbSet<Doctor> Doctors {get;set;}
        // public DbSet<DoctorManagement> DoctorsManagement{get;set;}
        // public DbSet <Dialog> Dialogs { get; set; }
        // public DbSet <Result> Results { get; set; }
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        // protected override void OnModelCreating(ModelBuilder builder)
        // {   
        //     builder.Entity<Result>()
        // .HasOne(p => p.dialog)
        // .WithOne(b => b.Result)
        // .OnDelete(DeleteBehavior.Cascade);
        //     base.OnModelCreating(builder);
        // }

    }
}