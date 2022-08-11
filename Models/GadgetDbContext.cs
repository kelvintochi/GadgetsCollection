using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GadgetsCollection.Models
{
        public class GadgetDbContext : DbContext
        {
            public GadgetDbContext(DbContextOptions<GadgetDbContext> options) : base(options)
            {

            }
            public DbSet<Gadget> Gadgets { get; set; }
        }
}
