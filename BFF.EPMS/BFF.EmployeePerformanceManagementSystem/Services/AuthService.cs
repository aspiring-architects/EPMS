using BFF.EPMS.Services.Interfaces;
using BFF.EPMS.ViewModels.Login;
using Newtonsoft.Json;

namespace BFF.EmployeePerformanceManagementSystem.Services
{
    public class AuthService: IAuthService
    {
        public string MicroLoginServiceUrl { get; set; } = "https://localhost:7053/";
        public LoginResponse? Login(LoginRequest request)
        {
            HttpClient client = new();
            string jsonRequestString = JsonConvert.SerializeObject(request);
            StringContent content = new(jsonRequestString);
            HttpResponseMessage response = client.PostAsync(MicroLoginServiceUrl + "/api/Login", content).Result;
            if(response.IsSuccessStatusCode)
            {
                string responseJson = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<LoginResponse>(responseJson);
            }
            else
            {
                return new LoginResponse();
            }            
        }
    }
}
