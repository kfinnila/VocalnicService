using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VocalnicService.Models
{
    public class VocalnicServiceContext : DbContext
    {
        public VocalnicServiceContext (DbContextOptions<VocalnicServiceContext> options)
            : base(options)
        {
        }

        public DbSet<VocalnicService.Models.Exercise> Exercise { get; set; }
    }
}
