using System;
using CheAutoRemastered.Application.Interfaces;
using CheAutoRemastered.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class CheAutoDbContext : DbContext, ICheAutoDbContext
    {
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Country> Countries { get; set; }

        public CheAutoDbContext(DbContextOptions<CheAutoDbContext> options) : base(options){}
    }
}
