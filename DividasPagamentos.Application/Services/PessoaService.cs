using AutoMapper;
using DividasPagamentos.Application.Interfaces;
using DividasPagamentos.Domain.DTOs;
using DividasPagamentos.Domain.Entidades;
using DividasPagamentos.Infra.Interfaces;

namespace DividasPagamentos.Application.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IMapper _mapper;
        //private readonly DatabaseContext _databaseContext;
        private readonly IPessoaRepository _repository;

        public PessoaService(IMapper mapper, IPessoaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public PessoaDTO? CreatePessoa(PessoaDTO pessoa)
        {
            var newPessoa = _mapper.Map<Pessoa>(pessoa);

            try
            {
                _repository.Add(newPessoa);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }

            return pessoa;
        }

        public Pessoa? GetPessoa(int id)
        {
            var pessoa = _repository.GetById(id);

            if (pessoa == null) return null;

            return pessoa;
        }

        public IEnumerable<Pessoa>? GetPessoas()
        {
            var pessoas = _repository.GetAll();

            if (!pessoas.Any()) return null;

            return pessoas;
        }
    }
}
