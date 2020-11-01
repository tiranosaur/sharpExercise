using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using sharpExercise.Models;

namespace sharpExercise
{
    public class ApplicationContext : DbContext
    {
        internal DbSet<User> users { get; set; }
        internal DbSet<Valute> currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = config.GetConnectionString("Default");
            optionsBuilder.UseMySql(connectionString);
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