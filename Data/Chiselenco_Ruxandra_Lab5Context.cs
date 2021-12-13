using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chiselenco_Ruxandra_Lab5.Models;

namespace Chiselenco_Ruxandra_Lab5.Data
{
    public class Chiselenco_Ruxandra_Lab5Context : DbContext
    {
        public Chiselenco_Ruxandra_Lab5Context (DbContextOptions<Chiselenco_Ruxandra_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Chiselenco_Ruxandra_Lab5.Models.Book> Book { get; set; }

        public DbSet<Chiselenco_Ruxandra_Lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Chiselenco_Ruxandra_Lab5.Models.Category> Category { get; set; }
    }
}
