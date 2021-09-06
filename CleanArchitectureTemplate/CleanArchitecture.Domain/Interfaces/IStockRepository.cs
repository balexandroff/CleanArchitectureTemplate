using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IStockRepository: IRepository
    {
        public IEnumerable<Stock> GetAll();
    }
}
