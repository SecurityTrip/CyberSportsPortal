using CyberSportsPortal.Core.Mappers;
using CyberSportsPortal.Data;
using CyberSportsPortal.Data.Model.Views;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CyberSportsPortal.Core.Services;

public class PlayerService
{
    private readonly CyberSportsContext _context;
    private readonly PlayerMapper _mapper;

    public PlayerService(CyberSportsContext context, PlayerMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<PlayerView>> GetPlayersAsync()
    {
        var players = await _context.Players
            .Include(x => x.Team)
            .ToListAsync();
        return _mapper.MapList(players);
    }
}