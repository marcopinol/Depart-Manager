using AutoMapper;
using DepartManagerWebAPI.Dto;
using DepartManagerWebAPI.Models;

namespace DepartManagerWebAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Departamento, DepartamentoDto>();
            CreateMap<DepartamentoDto, Departamento>(); 
        }
    }
}
