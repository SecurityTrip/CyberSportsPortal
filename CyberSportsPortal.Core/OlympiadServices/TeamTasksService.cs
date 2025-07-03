using CyberSportsPortal.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberSportsPortal.Core.OlympiadServices;

public class TeamTasksService
{
    public int GetTeamIncomeForYear(Team team, int year)
    {
        if (team == null)
            return 0;

        int result = 0;

        // Проверяем null коллекции
        var tournaments = team.TeamTournamentResults ?? Enumerable.Empty<TournamentParticipantInfo>();

        foreach (var t in tournaments)
        {
            if (t == null)
                continue;

            if (t.Tournament?.EndDate == null)
                continue;

            if (t.Tournament.EndDate.Year != year)
                continue;

            var prizes = t.Tournament.TournamentPrizes ?? Enumerable.Empty<TournamentPrize>();

            foreach (var p in prizes)
            {
                if (p == null)
                    continue;

                if (EqualityComparer<int?>.Default.Equals(t.Place, p.Place))
                {
                    result += p.Prize;
                }
            }
        }

        return result;
    }

    public List<Rating> GetNewRatings(List<MatchHistory> matches, List<Rating> oldRatings)
    {
        return oldRatings;
    }
}