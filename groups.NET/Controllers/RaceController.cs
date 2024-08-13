using groups.NET.Data;
using groups.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace groups.NET.Controllers;

public class RaceController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public RaceController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        List<Race> races = _context.Races.ToList();
        return View(races);
    }
}