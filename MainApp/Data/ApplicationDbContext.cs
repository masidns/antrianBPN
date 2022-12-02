using MainApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MainApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Petugas> Petugas { get; set; }
        public DbSet<Layanan> Layanans { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Antrian> Antrians { get; set;}

    }
}