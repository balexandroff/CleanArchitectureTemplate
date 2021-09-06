using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class CountryRepository: BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(StocksDbContext context) : base(context) { }

        public IEnumerable<Country> GetAll()
        {
            return _context.Countries.ToList();
        }
    }
}
