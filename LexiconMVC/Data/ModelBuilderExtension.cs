using LexiconMVCData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVCData.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Adam Adamsson", PhoneNumber = "031-123456", City = "Göteborg" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Bertil Bertilsson", PhoneNumber = "031-123456", City = "Malmö" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Carl Carlsson", PhoneNumber = "031-123456", City = "Stockholm" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 4, Name = "Dan Danielsson", PhoneNumber = "031-123456", City = "Göteborg" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 5, Name = "Erik Eriksson", PhoneNumber = "031-123456", City = "Malmö" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 6, Name = "Frans Fransson", PhoneNumber = "031-123456", City = "Stockholm" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 7, Name = "Gustav Gustavsson", PhoneNumber = "031-123456", City = "Göteborg" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 8, Name = "Henrik Henriksson", PhoneNumber = "031-123456", City = "Malmö" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 9, Name = "Ivar Ivarsson", PhoneNumber = "031-123456", City = "Stockholm" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 10, Name = "Jan Jansson", PhoneNumber = "031-123456", City = "Göteborg" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 11, Name = "Karl Karlsson", PhoneNumber = "031-123456", City = "Malmö" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 12, Name = "Lars Larsson", PhoneNumber = "031-123456", City = "Stockholm" });

        }

    }
}
