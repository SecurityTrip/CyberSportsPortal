using CyberSportsPortal.Data.Entities;
using System.Collections.Generic;

namespace CyberSportsPortal.Core.OlympiadServices;

public class TeamTasksService
{
    public int GetTeamIncomeForYear(Team team, int year)
    {
        return 100;
    }

    public List<Rating> GetNewRatings(List<MatchHistory> matches, List<Rating> oldRatings)
    {
        return oldRatings;
    }
}