using CyberSportsPortal.Core.Mappers;
using CyberSportsPortal.Core.OlympiadServices;
using CyberSportsPortal.Data;
using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Views;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberSportsPortal.Core.Services;

public class TournamentService
{
    private readonly CyberSportsContext _context;
    private readonly TournamentMapper _tournamentMapper;
    private readonly TournamentTasksService _tournamentTasksService;

    public TournamentService(
        CyberSportsContext context,
        TournamentMapper tournamentMapper,
        TournamentTasksService tournamentTasksService)
    {
        _context = context;
        _tournamentMapper = tournamentMapper;
        _tournamentTasksService = tournamentTasksService;
    }

    public async Task<List<TournamentView>> GetTournamentsAsync()
    {
        var tournaments = await _context.Tournaments.ToListAsync();
        return _tournamentMapper.MapList(tournaments);
    }

    public async Task<Tournament> GetLastTournamentAsync()
    {
        return await _context.Tournaments
            .Include(x => x.TeamParticipantInfos)
                .ThenInclude(x => x.Team)
            .OrderByDescending(x => x.EndDate)
            .FirstAsync();
    }

    public List<TournamentPrize> GetTournamentPrizesAsync(int id)
    {
        return _context.TournamentPrizes.Where(x => x.TournamentId == id).OrderBy(x => x.Place).ToList();
    }

    public async Task<Tournament> GetTournamentByIdAsync(int id)
    {
        return await _context.Tournaments
            .Include(x => x.TeamParticipantInfos)
                .ThenInclude(x => x.Team)
                    .ThenInclude(x => x.Players)
            .Include(x => x.TournamentPrizes)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public List<PlayersPerCountry> GetPlayersPerCountries(Tournament tournament)
    {
        var players = tournament.TeamParticipantInfos.SelectMany(x => x.Team.Players).ToList();
        var countries = players.Select(x => x.Country).Distinct().ToList();

        return countries
            .Select(x =>
                new PlayersPerCountry
                {
                    Country = x,
                    PlayersCount = _tournamentTasksService.GetPlayersFromCountryCount(players, x)
                })
            .OrderByDescending(x => x.PlayersCount)
            .ToList();
    }
}