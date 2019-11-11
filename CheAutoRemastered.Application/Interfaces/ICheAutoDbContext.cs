using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CheAutoRemastered.Domain.Models;

namespace CheAutoRemastered.Application.Interfaces
{
    public interface ICheAutoDbContext
    {
        DbSet<Domain.Models.Engine> Engines { get; set; }
        DbSet<Country> Countries { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
