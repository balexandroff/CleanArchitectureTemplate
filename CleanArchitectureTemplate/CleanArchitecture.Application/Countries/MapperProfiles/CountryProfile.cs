using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.ViewModels.MapperProfiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryViewModel>();
        }
    }
}
