using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DividasPagamentos.Domain.Entidades
{
    public abstract class Entidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }

        protected Entidade()
        {
            DataCriacao = DateTime.Now;
            Ativo = true;
        }
    }
}
