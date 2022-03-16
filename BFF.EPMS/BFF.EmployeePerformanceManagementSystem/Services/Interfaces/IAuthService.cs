using BFF.EPMS.ViewModels.Login;

namespace BFF.EPMS.Services.Interfaces
{
    public interface IAuthService
    {
       LoginResponse? Login(LoginRequest request);
    }
}
