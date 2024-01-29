using AutoMapper;
using DividasPagamentos.Domain.DTOs;
using DividasPagamentos.Domain.Entidades;

namespace DividasPagamentos.Application.AutoMappers
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<PessoaDTO, Pessoa>();
            CreateMap<Pessoa, PessoaDTO>();
        }
    }
}
