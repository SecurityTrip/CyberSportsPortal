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

        var tournaments = team.TeamTournamentResults;

        foreach (var t in tournaments)
        {
            if (t == null)
                continue;

            if (t.Tournament?.EndDate == null)
                continue;

            if (t.Tournament.EndDate.Year != year)
                continue;

            var prizes = t.Tournament.TournamentPrizes;

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
        if (matches == null || !matches.Any() || oldRatings == null || !oldRatings.Any())
            return oldRatings;

        var currentRatings = oldRatings.ToDictionary(r => r.TeamId, r => r.Score);

        var sortedMatches = matches.OrderBy(m => m.Date).ToList();

        foreach (var match in sortedMatches)
        {
            if (!currentRatings.ContainsKey(match.WinnerId) || !currentRatings.ContainsKey(match.LoserId))
                continue;

            var winnerRating = currentRatings[match.WinnerId];
            var loserRating = currentRatings[match.LoserId];

            int ratingChange;

            if (winnerRating == loserRating)
            {
                ratingChange = (int)(loserRating * 0.1);
            }
            else if (winnerRating < loserRating)
            {
                ratingChange = (int)(loserRating * 0.1);
            }
            else
            {
                ratingChange = (int)(loserRating * 0.01);
            }

            currentRatings[match.WinnerId] += ratingChange;
            currentRatings[match.LoserId] -= ratingChange;

            if (currentRatings[match.LoserId] < 0)
            {
                currentRatings[match.WinnerId] += currentRatings[match.LoserId];
                currentRatings[match.LoserId] = 0;
            }
        }

        var newRatings = new List<Rating>();
        var currentMoment = DateTimeOffset.UtcNow;

        foreach (var rating in oldRatings)
        {
            newRatings.Add(new Rating
            {
                TeamId = rating.TeamId,
                Score = currentRatings[rating.TeamId],
                AtMoment = currentMoment,
                Team = rating.Team
            });
        }

        return newRatings;
    }
}