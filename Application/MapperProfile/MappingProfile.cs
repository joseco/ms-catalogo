using Application.Dto;
using AutoMapper;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Categoria, CategoriaDto>();
            CreateMap<Articulo, ArticuloDto>()
                .ForMember(dest => dest.Categoria, act => act.MapFrom( src => src.Categoria));
        }
    }
}
