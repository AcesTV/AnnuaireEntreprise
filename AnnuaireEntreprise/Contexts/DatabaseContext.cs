using AnnuaireEntreprise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireEntreprise.Contexts
{
    class DatabaseContext : DbContext
    {
        #region Ctor
        public DatabaseContext() : base()
        {                   
        }
        #endregion
        #region DBsets
        public DbSet<Service>? Services { get; set; }
        public DbSet<Site>? Sites { get; set; }
        public DbSet<Salarie>? Salaries { get; set; }

        #endregion
        #region Config

        public static string GetConnectionString()
        {
            return "Server=(localdb)\\mssqllocaldb;Database=annuaireentreprise;Trusted_Connection=True;MultipleActiveResultSets=true";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                var _connectionString = GetConnectionString();
                optionsBuilder.UseSqlServer(_connectionString);
                optionsBuilder.EnableSensitiveDataLogging();
            }
            base.OnConfiguring(optionsBuilder);
        }

        #endregion

        #region Mapping
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Services
            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired();
            });
            #endregion

            #region Sites
            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Ville).IsRequired();
            });

            #endregion

            #region Salaries
            modelBuilder.Entity<Salarie>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nom).IsRequired();
                entity.Property(e => e.Prenom).IsRequired();
                entity.Property(e => e.TelPortable).IsRequired();
                entity.Property(e => e.TelFixe).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.HasOne(d => d.Services).WithMany(p => p.Salaries);
                entity.HasOne(d => d.Site).WithMany(p => p.Salaries);
            });
            #endregion


        }

        internal object Entity(Salarie salaries)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
