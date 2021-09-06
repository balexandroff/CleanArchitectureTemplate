using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IInvestmentRepository: IRepository
    {
        public IEnumerable<Investment> GetAll();
    }
}
