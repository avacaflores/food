using Microsoft.AspNetCore.Mvc;

namespace food.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "+555-666-333";
        }

        public string Address()
        {
            return "+555-666-333";
        }
    }
}