using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EF
{
    public class Task2DbContext : DbContext
    {
        public Task2DbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*  modelBuilder.Seed();*/
            //Data seeding
            //base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data seeding
            /* IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();*/

            //var connectionString = configuration.GetConnectionString("Task2");

            //optionsBuilder.UseySql("Server=localhost;User=root;password=;database=Task2;", ServerVersion.AutoDetect("Server=localhost;User=root;password=;database=Task2;"));
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserDailyTimesheetModel> UserDailyTimesheetModels { get; set; }
    }
}