using AutoMapper;
using MvcValidation.ControllersViewModels.Customer;
using MvcValidation.Models;

namespace MvcValidation.App_Start
{
    public class MapperProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Customer, CustomerIndexItemVM>();
        }
    }
}
