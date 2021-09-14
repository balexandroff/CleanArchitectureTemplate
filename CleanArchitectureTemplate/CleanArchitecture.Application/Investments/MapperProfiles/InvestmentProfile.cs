using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.ViewModels.MapperProfiles
{
    public class InvestmentProfile : Profile
    {
        public InvestmentProfile()
        {
            CreateMap<Investment, InvestmentViewModel>();
        }
    }
}
