using Microsoft.Extensions.Configuration;

namespace Web3
{
    public interface IGreeter
    {
        string GetMsgOfTheDAY();
    }

    public class Greeter:IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {

            _configuration = configuration;
            
        }

        public string GetMsgOfTheDAY()
        {
            return _configuration["Greetings"];
        }
    }

}

