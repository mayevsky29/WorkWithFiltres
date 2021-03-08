using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddFiltrsInMagazine.EfContex
{
    public class EFContext : DbContext
    {
        public DbSet<FilterName> FilterNames { get; set; }
        public DbSet<FilterValue> FilterValues { get; set; }
        public DbSet<FilterNameGroup> FilterNameGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=mayevskydb;Username=maey;Password=$544$B77w**G)K$t!Ube22}mav");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<FilterNameGroup>(filterNG =>
            {
                filterNG.HasKey(f => new { f.FilterValueId, f.FilterNameId });

                filterNG.HasOne(ur => ur.FilterNameOf)
                    .WithMany(r => r.FilterNameGroups)
                    .HasForeignKey(ur => ur.FilterNameId)
                    .IsRequired();

                filterNG.HasOne(ur => ur.FilterValueOf)
                    .WithMany(r => r.FilterNameGroups)
                    .HasForeignKey(ur => ur.FilterValueId)
                    .IsRequired();
            });

        }

    }
}
