using CleanArchitecture.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IInvestmentService: IService
    {
        public IEnumerable<InvestmentViewModel> GetAll();
    }
}
