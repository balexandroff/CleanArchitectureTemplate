using CleanArchitecture.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICountryService: IService
    {
        public IEnumerable<CountryViewModel> GetAll();
    }
}
