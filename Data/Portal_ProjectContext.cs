using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portal_Project.Models;

namespace RoundTwo.Data
{
    public class Portal_ProjectContext : DbContext
    {
        public Portal_ProjectContext (DbContextOptions<Portal_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Portal_Project.Models.Round_Two> Round_Two { get; set; }
    }
}
