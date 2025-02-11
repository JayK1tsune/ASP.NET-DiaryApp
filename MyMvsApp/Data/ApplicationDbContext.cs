using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMvsApp.Models;

namespace MyMvsApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //DbSet property
        public DbSet<DiaryEntry> DiaryEntries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed the database with some initial data
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "First Entry",
                    Created = new DateTime(2021, 1, 1),
                    Content = "This is the first entry in the diary."
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Second Entry",
                    Created = new DateTime(2021, 1, 1),
                    Content = "This is the second entry in the diary."
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Third Entry",
                    Created = new DateTime(2021, 1, 1),
                    Content = "This is the third entry in the diary."
                }
            );
        }

        // four steps to add a table to the database
        // 1. create a model class
        // 2. add a DbSet property to the DbContext class
        // 3. create a migration
        // 4. apply the migration to the database
    }
}