using LexiconMVCData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVCData.Data
{
    public class LexiconMVCDbContext :DbContext
    {
        public LexiconMVCDbContext(DbContextOptions<LexiconMVCDbContext> options) : base (options)
        {

        }
        
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
