namespace DividasPagamentos.Domain.DTOs
{
    public class DividaDTO
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public EmpresaDTO Empresa { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public PessoaDTO Pagador { get; set; }
    }
}
