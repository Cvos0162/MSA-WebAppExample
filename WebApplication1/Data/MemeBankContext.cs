using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class MemeBankContext : DbContext
    {
        public MemeBankContext (DbContextOptions<MemeBankContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.MemeItem> MemeItem { get; set; }
    }
}
