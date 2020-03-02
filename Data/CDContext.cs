using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDShop.Models;

namespace CDShop.Data
{
    public class CDContext : DbContext
    {
        public CDContext(DbContextOptions<CDContext> options) : base(options)
        { 
        }

        public DbSet<CD> CDs { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
