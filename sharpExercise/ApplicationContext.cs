using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using sharpExercise.Models;

namespace sharpExercise
{
    public class ApplicationContext : DbContext
    {
        internal DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = config.GetConnectionString("Default");
            optionsBuilder.UseMySql(connectionString);
            //optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=png;password=png;database=png;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() {Id = 1, Username = "Tiran", Email = "tiran@mail.ru"},
                new User() {Id = 2, Username = "tiranosaur", Email = "tiranosaur@mail.ru"},
                new User() {Id = 3, Username = "Admin", Email = "admin@admin.com"},
                new User() {Id = 4, Username = "user", Email = "user@gmail.com"},
                new User() {Id = 5, Username = "roman", Email = "roman@mail.ru"}
            );
        }
    }
}