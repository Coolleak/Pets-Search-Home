using System;
using System.Collections.Generic;
using System.Text;
using DAL.EF.Records;
using Microsoft.EntityFrameworkCore;


namespace DAL.EF.Context
{
    public class ApplicationContext:DbContext
    {
        public DbSet<UserRecord> Users { get; set; }
        public DbSet<AnimalRecord> Animals { get; set; }
        public DbSet<ShelterRecord> Shelter { get; set; }
        public DbSet<PostRecord> Posts { get; set; }
        public DbSet<ComplainsRecord> Complains { get; set; }
        public DbSet<FavoritesRecord> Favorites { get; set; } 
        public DbSet<AddressRecord> Addresses { get; set; }
        public DbSet<ColorRecord> AnimalColors { get; set; }

        public ApplicationContext()
        {
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PSHDatabase;Trusted_Connection=True;");
        }
    }
}
