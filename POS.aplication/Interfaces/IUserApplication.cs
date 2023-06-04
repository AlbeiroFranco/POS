using POS.Aplication.Commons.Bases;
using POS.Aplication.Dtos.User.Request;

namespace POS.Aplication.Interfaces
{
    public interface IUserApplication
    {
        Task<BaseResponse<bool>> RegisterUser(UserRequestDto requestDto);
        Task<BaseResponse<string>> GenerateToken(TokenRequestDto requestDto);
        Task RegisterUser(object requestDto);
    }
}
