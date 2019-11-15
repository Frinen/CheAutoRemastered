using System;
using System.Threading;
using System.Threading.Tasks;
using CheAutoRemastered.Application.Interfaces;
using CheAutoRemastered.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class CheAutoDbContext : DbContext, ICheAutoDbContext
    {
        public DbSet<Engine> Engines { get; set; }
        //public DbSet<Country> Countries { get; set; }
        //public DbSet<CarComplectation> CarComplectations { get; set; }
        public CheAutoDbContext(DbContextOptions<CheAutoDbContext> options) : base(options){}

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ChangeTracker.DetectChanges();
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
