using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArchitecture.Aplication.Services
{
    public class StockService
    {
        private readonly IMapper _mapper;

        private readonly IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository, IMapper mapper)
        {
            this._stockRepository = stockRepository;
            this._mapper = mapper;
        }

        public IEnumerable<StockViewModel> GetAll()
        {
            var allStocks = this._stockRepository.GetAll();

            return this._mapper.Map<IEnumerable<StockViewModel>>(allStocks);
        }
    }
}
