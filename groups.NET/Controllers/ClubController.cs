using groups.NET.Data;
using groups.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace groups.NET.Controllers;

public class ClubController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public ClubController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        List<Club> clubs = _context.Clubs.ToList();
        return View(clubs);
    }
}