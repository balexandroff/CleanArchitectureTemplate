using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IStockRepository: IRepository
    {
        public Task<IEnumerable<Stock>> GetAllAsync(CancellationToken cancellationToken);
    }
}
