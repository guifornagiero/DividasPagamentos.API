using DividasPagamentos.Domain.Responses;

namespace DividasPagamentos.Application.Interfaces
{
    public interface IResponseService
    {
        CreateResponse CreateResponse(string mensagem, string status);
    }
}
