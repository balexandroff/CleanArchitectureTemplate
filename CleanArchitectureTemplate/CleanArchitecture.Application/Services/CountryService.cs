using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Services
{
    public class CountryService
    {
        private readonly IMapper _mapper;

        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {
            this._countryRepository = countryRepository;
            this._mapper = mapper;
        }

        public IEnumerable<CountryViewModel> GetAll()
        {
            var allCountries = this._countryRepository.GetAll();

            return this._mapper.Map<IEnumerable<CountryViewModel>>(allCountries);
        }
    }
}
