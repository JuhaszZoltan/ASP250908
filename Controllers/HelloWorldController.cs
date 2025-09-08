using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers;

public class HelloWorldController : Controller
{
    //GET: /HelloWorld/{Index}
    public IActionResult Index()
    {
        return View();
    }

    //GET: /HelloWorld/Welcome/Zolikaaa/21
    public IActionResult Welcome(string name, int number = 1)
    {
        ViewData["Message"] = $"Hello {name}!";
        ViewData["Number"] = number;

        return View();
    }
}
