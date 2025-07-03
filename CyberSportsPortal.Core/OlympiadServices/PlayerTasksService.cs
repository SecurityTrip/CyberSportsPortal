using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Views;
using System;
using System.Collections.Generic;

namespace CyberSportsPortal.Core.OlympiadServices;

public class PlayerTasksService
{
    public List<PlayerView> FilterPlayers(List<PlayerView> players, string filter)
    {
        List<PlayerView> playersToShow = new List<PlayerView>();
        if (players == null || string.IsNullOrEmpty(filter))
        {
            return new List<PlayerView>();
        }

        foreach (PlayerView player in players)
        {
            if (player.NickName != null && player.NickName.Contains(filter, StringComparison.OrdinalIgnoreCase))
            {
                playersToShow.Add(player);
                continue;
            }
            if (player.CombinedName != null && player.CombinedName.Contains(filter, StringComparison.OrdinalIgnoreCase))
            {
                playersToShow.Add(player);
            }
        }
        return playersToShow;
    }
}