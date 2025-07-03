using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Enums;
using CyberSportsPortal.Data.Model.Views;
using System.Collections.Generic;

namespace CyberSportsPortal.Core.OlympiadServices;

public class TournamentTasksService
{
    public string GetTournamentStatus(Tournament tournament)
    {
        return string.Empty;
    }

    public int GetPlayersFromCountryCount(List<Player> players, Country country)
    {
        return 0;
    }

    public string GetTeamParticipantsNameString(List<Team> teams)
    {
        string result = string.Empty;
        for (int i = 0; i < teams.Count; i++)
        {
            result += teams[i].Name + ", ";
        }

        return result;
    }

    public int ComparePrizes(string prizeA, string prizeB)
    {
        if (prizeA == prizeB)
            return 0;
        if (prizeA[prizeA.Length - 1] > prizeB[prizeB.Length - 1])
            return 1;
        else
            return -1;
    }

    public Dictionary<int, decimal> GetTournamentVictoryProbabilities(List<TeamWithVictoryProbabilities> teams, Dictionary<int, int> standings)
    {
        return new Dictionary<int, decimal>();
    }
}