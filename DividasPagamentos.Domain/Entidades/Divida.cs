using System.ComponentModel.DataAnnotations;

namespace DividasPagamentos.Domain.Entidades
{
    public class Divida
    {
        [Key]
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Empresa Empresa { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public Pessoa Pagador { get; set;}
        public bool Pago { get; set;}
        public bool Ativo { get; set;}

        public Divida(Guid id, string titulo, string descricao, Empresa empresa, double valor, DateTime dataPagamento, DateTime dataCriacao, Pessoa pagador, bool pago, bool ativo)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Descricao = descricao;
            Empresa = empresa;
            Valor = valor;
            DataPagamento = dataPagamento;
            DataCriacao = DateTime.Now;
            Pagador = pagador;
            Pago = false;
            Ativo = true;
        }
    }
}
