using AutoMapper;
using WebApplication4.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductViewModel, Product>();
    }
}
