using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICountryRepository: IRepository
    {
        public IEnumerable<Country> GetAll();
    }
}
