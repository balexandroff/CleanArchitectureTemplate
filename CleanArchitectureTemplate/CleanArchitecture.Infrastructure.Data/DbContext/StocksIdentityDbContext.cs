using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public class StocksIdentityDbContext : IdentityDbContext
{
    public StocksIdentityDbContext(DbContextOptions<StocksIdentityDbContext> options)
            : base(options)
    {
    }

    //public DbSet<AspNetUsers> AspNetUsers { get; set; }
    //public DbSet<AspNetRoles> AspNetRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        // ignore events if no dispatcher provided
        //if (_mediator == null) return result;

        // dispatch events only if save was successful
        //var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
        //    .Select(e => e.Entity)
        //    .Where(e => e.Events.Any())
        //    .ToArray();

        //foreach (var entity in entitiesWithEvents)
        //{
        //    var events = entity.Events.ToArray();
        //    entity.Events.Clear();
        //    foreach (var domainEvent in events)
        //    {
        //        await _mediator.Publish(domainEvent).ConfigureAwait(false);
        //    }
        //}

        return result;
    }

    public override int SaveChanges()
    {
        return SaveChangesAsync().GetAwaiter().GetResult();
    }
}
