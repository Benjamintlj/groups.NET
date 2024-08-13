using groups.NET.Data;
using groups.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace groups.NET.Controllers;

public class RaceController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public RaceController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        List<Race> races = _context.Races.ToList();
        return View(races);
    }

    public IActionResult Detail(int id)
    {
        Race? race = _context.Races.Include(a => a.Address).FirstOrDefault(r => r.Id == id);
        return View(race);
    }
}