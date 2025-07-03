using CyberSportsPortal.Data;
using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberSportsPortal.Core.Services;

public class RatingService
{
    private readonly CyberSportsContext _context;

    public RatingService(CyberSportsContext context)
    {
        _context = context;
    }

    public async Task<List<Rating>> GetTournamentParticipantsRatingAsync(Tournament tournament)
    {
        var teams = tournament.TeamParticipantInfos.Select(x => x.Team).ToList();
        var ratings = new List<Rating>();
        foreach (var team in teams.AsParallel())
        {
            ratings.Add(await _context.Ratings.FirstAsync(x => x.TeamId == team.Id));
        }

        return ratings;
    }
}