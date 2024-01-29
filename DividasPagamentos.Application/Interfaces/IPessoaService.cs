using DividasPagamentos.Domain.DTOs;
using DividasPagamentos.Domain.Entidades;

namespace DividasPagamentos.Application.Interfaces
{
    public interface IPessoaService
    {
        Pessoa? GetPessoa(int id);
        PessoaDTO? CreatePessoa(PessoaDTO pessoa);
        IEnumerable<Pessoa>? GetPessoas();
    }
}
