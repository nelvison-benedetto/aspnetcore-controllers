using Microsoft.AspNetCore.Mvc;
 
namespace _4_aspnetcore_controllers.Controllers;

public class StoreController : Controller
{
    [Route("store/books/{id}")]
    public IActionResult GetBooks()
    {
        int id = Convert.ToInt32(Request.RouteValues["id"]);
        return Content($"List of books from StoreController, {id}", "text/plain");

    }
}
