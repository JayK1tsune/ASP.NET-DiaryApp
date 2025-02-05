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

        // four steps to add a table to the database
        // 1. create a model class
        // 2. add a DbSet property to the DbContext class
        // 3. create a migration
        // 4. apply the migration to the database
    }
}