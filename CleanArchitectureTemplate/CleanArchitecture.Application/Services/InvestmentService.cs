using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Services
{
    public class InvestmentService: IInvestmentService
    {
        private readonly IMapper _mapper;

        private readonly IInvestmentRepository _investmentRepository;


        public InvestmentService(IInvestmentRepository investmentRepository, IMapper mapper)
        {
            this._investmentRepository = investmentRepository;
            this._mapper = mapper;
        }

        public IEnumerable<InvestmentViewModel> GetAll()
        {
            var allInvestments = this._investmentRepository.GetAll();

            return this._mapper.Map<IEnumerable<InvestmentViewModel>>(allInvestments);
        }
    }
}
