using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IbnMasjjed.Domain;

namespace IbnMasjjed.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         

            modelBuilder.Entity<CityLookup>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<RegionLookup>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Mosque>().HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<CityPolygon>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<CityPolygonPoint>().HasQueryFilter(p => !p.IsDeleted);


        }




        public DbSet<CityLookup> CityLookup { get; set; }
        public DbSet<RegionLookup> RegionLookup { get; set; }
        public DbSet<Mosque> Mosque { get; set; }

        public DbSet<CityPolygon> CityPolygon { get; set; }
        public DbSet<CityPolygonPoint> CityPolygonPoint { get; set; }


    }
}
