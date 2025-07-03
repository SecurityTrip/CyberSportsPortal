using CyberSportsPortal.Data;
using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberSportsPortal.Core.Services;

public class MatchHistoryService
{
    private readonly CyberSportsContext _context;

    public MatchHistoryService(CyberSportsContext context)
    {
        _context = context;
    }

    public async Task<List<MatchHistory>> GetTournamentMatchHistoryAsync(int tournamentId)
    {
        return await _context.MatchHistories.Where(x => x.TournamentId == tournamentId).ToListAsync();
    }
}