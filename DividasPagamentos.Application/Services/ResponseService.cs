using DividasPagamentos.Application.Interfaces;
using DividasPagamentos.Domain.Responses;

namespace DividasPagamentos.Application.Services
{
    public class ResponseService
    {

        public static CreateResponse CreateResponse(string mensagem, string status)
        {
            return new CreateResponse(mensagem, status);
        }
    }
}
