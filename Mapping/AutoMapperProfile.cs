using AutoMapper;
using Plataforma.Backend_.DTOs;
using Plataforma.Backend_.Models;


public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CriarProfissionalDto, Profissional>();
    }
}