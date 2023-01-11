using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portal_Project.Models;

    public class RoundOneContext : DbContext
    {
        public RoundOneContext (DbContextOptions<RoundOneContext> options)
            : base(options)
        {
        }

        public DbSet<RoundOne> RoundOne { get; set; }
        public DbSet<Round_Three> RoundThree { get; set; }


}
