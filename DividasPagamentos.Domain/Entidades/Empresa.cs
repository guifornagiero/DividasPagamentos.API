using System.ComponentModel.DataAnnotations;

namespace DividasPagamentos.Domain.Entidades
{
    public class Empresa : Entidade
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Guid CriadorId { get; set;}
        public virtual Pessoa Criador { get; set; }

        public Empresa() { }

        public Empresa(string titulo, string descricao, Guid criadorId, Pessoa criador)
        {
            Titulo = titulo;
            Descricao = descricao;
            CriadorId = criadorId;
            Criador = criador;
        }
    }
}
