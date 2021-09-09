using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        public StockRepository(StocksDbContext context) : base(context) { }

        public IEnumerable<Stock> GetAll()
        {
            return _context.Stocks.Include(s => s.Country).ToList();
        }
    }
}
