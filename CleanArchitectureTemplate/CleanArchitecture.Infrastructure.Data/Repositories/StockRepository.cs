﻿using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        public StockRepository(StocksDbContext context) : base(context) { }

        public async Task<IEnumerable<Stock>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Stocks.Include(s => s.Country).ToListAsync(cancellationToken);
        }
    }
}
