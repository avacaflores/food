using Microsoft.Extensions.Configuration;

namespace food.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;
        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        string IGreeter.GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}