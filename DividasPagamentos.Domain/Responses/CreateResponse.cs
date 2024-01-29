namespace DividasPagamentos.Domain.Responses
{
    public class CreateResponse
    {
        public string Mensagem { get; set; }
        public string Status { get; set; }

        public CreateResponse(string mensagem, string status)
        {
            Mensagem = mensagem;
            Status = status;
        }
    }
}
