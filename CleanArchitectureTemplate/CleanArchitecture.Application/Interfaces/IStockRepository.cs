using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitecture.Aplication.Interfaces
{
    public interface IStockService: IService
    {
        public IEnumerable<StockViewModel> GetAll();
    }
}
