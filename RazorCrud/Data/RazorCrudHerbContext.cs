using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudHerbContext : DbContext
    {
        public RazorCrudHerbContext (DbContextOptions<RazorCrudHerbContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Herb> Herb { get; set; }
    }
