using groups.NET.Data;
using groups.NET.Interfaces;
using groups.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace groups.NET.Controllers;

public class RaceController : Controller
{
    private readonly IRaceRepository _raceRepository;

    public RaceController(IRaceRepository raceRepository)
    {
        _raceRepository = raceRepository;
    }
    
    public async Task<IActionResult> Index()
    {
        IEnumerable<Race> races = await _raceRepository.GetAll();
        return View(races);
    }

    public async Task<IActionResult> Detail(int id)
    {
        Race race = await _raceRepository.GetByIdAsync(id);
        return View(race);
    }
}