using Microsoft.AspNetCore.Mvc;

namespace _4_aspnetcore_controllers.Controllers;

[Controller]
public class HomeController : ControllerBase  //:Controller invece lo usi se usi le View, ma per apis non ti servono
{
    [Route("hello1")]
    [Route("hello2")]
    [Route("/")]
    public string method1()
    {
        return "Hello from HomeController.method1";
    }

    [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
    public string contactUs()
    {
        return "Hello from HomeController.method1";
    }
}
