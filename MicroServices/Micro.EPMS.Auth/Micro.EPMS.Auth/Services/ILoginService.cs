using Micro.EPMS.Auth.ViewModels;

namespace Micro.EPMS.Auth.Services
{
    public interface ILoginService
    {
        LoginResponse GetUserResponse(string userName);
        bool ValidateLogin(LoginRequest request);
    }
}