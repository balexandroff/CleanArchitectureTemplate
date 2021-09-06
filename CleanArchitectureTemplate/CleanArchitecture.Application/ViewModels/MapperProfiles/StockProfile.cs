using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.ViewModels.MapperProfiles
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Stock, StockViewModel>();
        }
    }
}
