using AutoMapper;
using Shopping.Domain.Entities.Entities;
using Shopping.Endpoint.MVC.Models;
using System.Linq;

namespace Shopping.Endpoint.MVC.Infrastructures.Mapping
{
    public static class AutoMapperStartupTask
    {
        public static void Execute()
        {
            Mapper.CreateMap<Factor, FactorListModel>()
                .ForMember(x => x.CustomerName, y => y.MapFrom(x => x.Customer.FName + x.Customer.LName))
                .ForMember(x => x.CountDetail, y => y.MapFrom(x => x.FactorDetails.Count()))
                .ReverseMap();
        }
    }

}
