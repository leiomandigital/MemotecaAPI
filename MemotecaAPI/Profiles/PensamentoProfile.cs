using AutoMapper;
using MemotecaAPI.Data.Dtos;
using MemotecaAPI.Models;

namespace MemotecaAPI.Profiles;

public class PensamentoProfile : Profile
{
    public PensamentoProfile()
    {
        CreateMap<CreatePensamentoDto, Pensamento>();
        CreateMap<UpdatePensamentoDto, Pensamento>();
        CreateMap<Pensamento, ReadPensamentoDto>();
    }
}
