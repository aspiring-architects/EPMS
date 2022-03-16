using BFF.EPMS.Services.Interfaces;
using BFF.EPMS.ViewModels.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BFF.EmployeePerformanceManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IAuthService Service { get; set; }
        public LoginController(IAuthService service)
        {
            Service = service;
        }

        [HttpPost]
        public LoginResponse Login(LoginRequest request)
        {
            try
            {
                LoginResponse? response = Service.Login(request);
                if (response != null)
                {
                    return response;
                }
                return new LoginResponse();
            }
            catch
            {
                throw;
            }
        }
    }
}
