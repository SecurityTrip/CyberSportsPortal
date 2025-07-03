using CyberSportsPortal.Core.Mappers;
using CyberSportsPortal.Data;
using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Views;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberSportsPortal.Core.Services;

public class TeamService
{
    private readonly CyberSportsContext _context;
    private readonly TeamMapper _mapper;

    public TeamService(CyberSportsContext context, TeamMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Team>> GetTeamsAsync()
    {
        return await _context.Teams.ToListAsync();
    }

    public async Task<Team> GetTeamByIdAsync(int id)
    {
        return await _context.Teams
            .Include(x => x.Players)
            .Include(x => x.TeamTournamentResults)
                .ThenInclude(x => x.Tournament)
                    .ThenInclude(x => x.TournamentPrizes)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<TeamWithVictoryProbabilities>> GetTeamsWithVictoryProbabilitiesForTournament(List<int> teamIds)
    {
        var result = new List<TeamWithVictoryProbabilities>();
        var teams = await _context.Teams.Where(x => teamIds.Contains(x.Id)).ToListAsync();
        foreach (var team in teams)
        {
            var probabilities = await _context.ProbabilityOfVictories
                .Where(x => x.LoserId == team.Id && teamIds.Contains(x.WinnerId) || x.WinnerId == team.Id && teamIds.Contains(x.LoserId)).ToListAsync();
            result.Add(_mapper.Map(team, probabilities));
        }

        return result;
    }
}