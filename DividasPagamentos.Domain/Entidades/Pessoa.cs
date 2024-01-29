using System.ComponentModel.DataAnnotations;

namespace DividasPagamentos.Domain.Entidades
{
    public class Pessoa : Entidade
    {
        [Required]
        [StringLength(20)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        public string Sobrenome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Idade { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string sobrenome, string email, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Idade = idade;
        }
    }
}
