using CleanArchitecture.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IStockService: IService
    {
        public IEnumerable<StockViewModel> GetAll();
    }
}
