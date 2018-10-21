using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagerApi.NetCore.Example.DB
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Test { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=test.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 1,
                Texto = "Prueba1"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 2,
                Texto = "Prueba2"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 3,
                Texto = "Prueba3"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 4,
                Texto = "Prueba4"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 5,
                Texto = "Prueba5"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 6,
                Texto = "Prueba6"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 7,
                Texto = "Prueba7"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 8,
                Texto = "Prueba8"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 9,
                Texto = "Prueba9"
            });

            modelBuilder.Entity<Test>().HasData(new Test()
            {
                Id = 10,
                Texto = "Prueba10"
            });
        }
    }

    public class Test
    {
        public int Id { get; set; }
        public string Texto { get; set; }
    }
}
