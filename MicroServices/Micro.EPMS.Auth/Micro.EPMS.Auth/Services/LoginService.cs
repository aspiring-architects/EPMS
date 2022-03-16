using AutoMapper;
using Login.DomainModels.Data;
using Micro.EPMS.Auth.ViewModels;

namespace Micro.EPMS.Auth.Services
{
    public class LoginService : ILoginService
    {
        private IMapper Mapper { get; }
        private UserDBContext DBContext { get; }
        public LoginService(UserDBContext context, IMapper mapper)
        {
            DBContext = context;
            Mapper = mapper;
        }

        public bool ValidateLogin(LoginRequest request)
        {
            return DBContext.Users.Any(u => u.UserName == request.UserName && u.Password == request.Password);
        }

        public LoginResponse GetUserResponse(string userName)
        {
            var user = DBContext.Users.Where(u => u.UserName == userName)
                .FirstOrDefault();
                
            return Mapper.Map<LoginResponse>(user);
        }
    }
}
