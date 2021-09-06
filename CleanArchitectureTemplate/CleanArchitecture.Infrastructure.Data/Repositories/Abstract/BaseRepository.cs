using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class BaseRepository<T> where T : AudutableEntity
    {
        protected readonly StocksDbContext _context;

        public BaseRepository(StocksDbContext context)
        {
            this._context = context;
        }
    }
}
