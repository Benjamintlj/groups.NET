using groups.NET.Data;
using groups.NET.Interfaces;
using groups.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace groups.NET.Repository;

public class RaceRepository : IRaceRepository
{
    private readonly ApplicationDbContext _context;
    
    public RaceRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Race>> GetAll()
    {
        return await _context.Races.ToListAsync();
    }

    public async Task<Race> GetByIdAsync(int id)
    {
        return await _context.Races.Include(r => r.Address).FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<IEnumerable<Race>> GetRaceByCity(string city)
    {
        return await _context.Races.Where(r => r.Address.City.Contains(city)).ToListAsync();
    }

    public bool Add(Race race)
    {
        _context.Add(race);
        return Save();
    }

    public bool Update(Race race)
    {
        _context.Update(race);
        return Save();
    }

    public bool Delete(Race race)
    {
        _context.Remove(race);
        return Save();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}
