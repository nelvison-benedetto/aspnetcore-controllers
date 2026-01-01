using _4_aspnetcore_controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4_aspnetcore_controllers.Controllers;

[Controller]
//public class HomeController : ControllerBase  //:Controller invece lo usi se usi le View, ma per apis non ti servono
public class HomeController : Controller
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

    [Route("home")]
    public ContentResult Index() {
        //return new ContentResult() { Content = "hello from index", ContentType = "text/plain" };

        //return Content("hello from index", "text/plain");

        return Content("<h1>Welcome</h1> <h2>hello from index</h2>","text/html");
    }

    [Route("person")]
    public JsonResult myPersonInJson() {
        Person person = new Person() { Id = Guid.NewGuid(), FirstName="Nevil", LastName="Benedict", Age=27 };
        //return new JsonResult(person);
        return Json(person);
        //return "{\"key\": \"value\"}";
    }

    [Route("file-download")]
    public VirtualFileResult FileDownload(){ //best x small files
        //return new VirtualFileResult("/sample.pdf", "application/pdf");
        return File("/sample.pdf", "application/pdf");
    }

    [Route("file-download2")]
    public PhysicalFileResult FileDownload2()  //best x big files
    {
        //return new PhysicalFileResult(@"C:\Users\nelvy\Downloads\clients.pdf", "application/pdf");
        return PhysicalFile(@"C:\Users\nelvy\Downloads\clients.pdf", "application/pdf");
    }

    [Route("file-download3")]
    public FileContentResult FileDownload3()  //rea all pdf->upload in RAM->transform in byte[]->send to client. alto consumo di RAM se big file
    {
        byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\nelvy\Downloads\clients.pdf");
        //return new FileContentResult(fileBytes, "application/pdf");
        return File(fileBytes, "application/pdf");
    }

    //ora al posto di usare nei methods VirtualFileResult/PhysicalFileResult/FileContentResult, puoi anche solo usare IActionResult (che è generico ok)


}
