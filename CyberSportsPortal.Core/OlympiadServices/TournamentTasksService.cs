using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Enums;
using CyberSportsPortal.Data.Model.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace CyberSportsPortal.Core.OlympiadServices;

public class TournamentTasksService
{
    public string GetTournamentStatus(Tournament tournament)
    {
        var currentDate = DateTime.UtcNow;
        if (tournament.EndDate <= currentDate)
        {
            return "Окончен";
        }
        else if (tournament.StartDate > currentDate)
        {
            return "Не начался";
        }

        return "В процессе";
    }

    public int GetPlayersFromCountryCount(List<Player> players, Country country)
    {
        if (players == null || country == null)
            return 0;

        var count = 0;
        foreach(Player player in players)
        {
            if (player?.Country == country)
                count++;
        }
        return count;
    }

    public string GetTeamParticipantsNameString(List<Team> teams)
    {
        if (teams == null || teams.Count == 0)
            return string.Empty;

        string result = string.Empty;
        for (int i = 0; i < teams.Count; i++)
        {
            if (teams[i]?.Name == null)
                continue;

            if(i < teams.Count - 1)
            {
                result += teams[i].Name + ", ";
            }
            else result += teams[i].Name;
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