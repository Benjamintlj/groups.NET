using Microsoft.AspNetCore.Mvc;

namespace groups.NET.Controllers;

public class ClubController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}