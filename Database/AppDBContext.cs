using Calender_KMVHP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender_KMVHP.Database
{
    public class AppDBContext: DbContext
    {
        public AppDBContext()

        {

         // Database.EnsureDeleted();
          Database.EnsureCreated();
        }
        public DbSet<Worker> workers => Set<Worker>();
        public DbSet<Monthh> months  => Set<Monthh>();
        public DbSet<Day> days => Set<Day>();
  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WORK_TABLE_FORMSS;Trusted_Connection=True;"); ;
        }

    }
}
