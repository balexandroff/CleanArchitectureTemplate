using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class InvestmentRepository : BaseRepository<Investment>, IInvestmentRepository
    {
        public InvestmentRepository(StocksDbContext context) : base(context) { }

        public IEnumerable<Investment> GetAll()
        {
            return _context.Investments.ToList();
        }
    }
}
