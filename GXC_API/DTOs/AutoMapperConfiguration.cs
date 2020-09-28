using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GXC_API.Models;

namespace GXC_API.DTOs
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<Libro, LibroDTO>().ReverseMap();
            //});

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Libro, LibroDTO>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Libro();
            var dest = mapper.Map<Libro, LibroDTO>(source);
        }
    }
}
