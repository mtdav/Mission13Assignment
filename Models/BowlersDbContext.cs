﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13Assignment.Models
{
    public class BowlersDbContext : DbContext
    {
        public BowlersDbContext(DbContextOptions<BowlersDbContext> options) : base (options)
        {

        }

        public DbSet<Bowler> Bowlers { get; set; }
    }
}
