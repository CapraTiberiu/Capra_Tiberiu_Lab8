using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capra_Tiberiu_Lab8.Models;

namespace Capra_Tiberiu_Lab8.Data
{
    public class Capra_Tiberiu_Lab8Context : DbContext
    {
        public Capra_Tiberiu_Lab8Context (DbContextOptions<Capra_Tiberiu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Capra_Tiberiu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Capra_Tiberiu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Capra_Tiberiu_Lab8.Models.Category> Category { get; set; }
    }
}
