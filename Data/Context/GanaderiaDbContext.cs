using Microsoft.EntityFrameworkCore;
using Ganaderia.Data.Models;

namespace Ganaderia.Data.Context;

public class GanaderiaDbContext:DbContext,IGanaderiaDbContext
{
    #region Constructor
    public GanaderiaDbContext(DbContextOptions options): base(options)
    {

    }
    #endregion

    #region Tablas
    public virtual DbSet<Vaca> Vacas => Set<Vaca>();
    public virtual DbSet<VacaComprada> Compradas => Set<VacaComprada>();
    public virtual DbSet<Padre> Padres => Set<Padre>();
    public virtual DbSet<Madre> Madres => Set<Madre>();
    #endregion

    #region Funciones
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
    #endregion
}