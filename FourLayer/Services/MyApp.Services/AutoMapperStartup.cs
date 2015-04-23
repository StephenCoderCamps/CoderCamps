using AutoMapper;
using MyApp.Domain.Models;
using MyApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class AutoMapperStartup
    {
        public static void RegisterMaps()
        {
            Mapper.CreateMap<Product, BriefProductDTO>();
            Mapper.CreateMap<Product, FullProductDTO>();
            Mapper.CreateMap<FullProductDTO, Product>();
        }
    }
}
