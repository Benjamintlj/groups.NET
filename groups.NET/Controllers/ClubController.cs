using groups.NET.Data;
using groups.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace groups.NET.Controllers;

public class ClubController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public ClubController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        List<Club> clubs = _context.Clubs.ToList();
        return View(clubs);
    }

    public IActionResult Detail(int id)
    {
        Club club = _context.Clubs.Include(c => c.Address).FirstOrDefault(c => c.Id == id);
        return View(club);
    }
}