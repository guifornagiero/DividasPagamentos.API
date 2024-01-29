using DividasPagamentos.Domain.Entidades;
using DividasPagamentos.Infra.Context;
using DividasPagamentos.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DividasPagamentos.Infra.Repositories
{
    public class PessoaRepository : Repositorio<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(DatabaseContext databaseContext) 
            : base(databaseContext) 
        {
        }
    }
}
