using Microsoft.EntityFrameworkCore;
using Ganaderia.Data.Models;

namespace Ganaderia.Data.Context;

public interface IGanaderiaDbContext
{
  DbSet<Vaca> Vacas { get; }
  Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}