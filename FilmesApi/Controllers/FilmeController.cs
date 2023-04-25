using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

public class FilmeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
