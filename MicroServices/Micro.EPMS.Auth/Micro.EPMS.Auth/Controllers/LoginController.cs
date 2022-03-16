using Micro.EPMS.Auth.Services;
using Micro.EPMS.Auth.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Micro.EPMS.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService LoginService { get; }

        public LoginController(ILoginService loginService)
        {
            LoginService = loginService;
        }

        [HttpPost]
        public IActionResult ValidateLogin(LoginRequest request)
        {
            try
            {
                if (LoginService.ValidateLogin(request))
                {
                    LoginResponse response = LoginService.GetUserResponse(request.UserName);
                    return Ok(response);
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
