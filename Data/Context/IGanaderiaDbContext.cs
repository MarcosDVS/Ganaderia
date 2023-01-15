using Microsoft.EntityFrameworkCore; //Libreria EntityFrameworkCore
using Ganaderia.Data.Models; //Modelo

namespace Ganaderia.Data.Context;

public interface IGanaderiaDbContext
{
  DbSet<Vaca> Vacas { get; }
  DbSet<VacaComprada> Compradas { get; }
  DbSet<Padre> Padres { get; }
  DbSet<Madre> Madres { get; }
  Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}