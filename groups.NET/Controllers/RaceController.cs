using Microsoft.AspNetCore.Mvc;

namespace groups.NET.Controllers;

public class RaceController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}