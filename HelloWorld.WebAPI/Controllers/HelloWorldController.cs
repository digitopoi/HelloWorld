using HelloWorld.Services;
using System.Web.Http;

namespace HelloWorld.WebAPI.Controllers
{
    public class HelloWorldController : ApiController
    {

        // GET api/HelloWorld
        public IHttpActionResult Get()
        {
            var helloWorldService = CreateHelloWorldService();
            string response = helloWorldService.HelloWorld();

            return Ok(response);
        }

        private HelloWorldService CreateHelloWorldService()
        {
            var helloWorldService = new HelloWorldService();
            return helloWorldService;
        }
    }
}
