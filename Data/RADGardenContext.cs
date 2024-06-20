using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RADGarden.Models;

namespace RADGarden.Data
{
    public class RADGardenContext : DbContext
    {
        public RADGardenContext (DbContextOptions<RADGardenContext> options)
            : base(options)
        {
        }

        public DbSet<RADGarden.Models.Product> Product { get; set; } = default!;
    }
}
