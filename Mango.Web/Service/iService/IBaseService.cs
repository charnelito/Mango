using Mango.Web.Models;

namespace Mango.Web.Service.iService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
