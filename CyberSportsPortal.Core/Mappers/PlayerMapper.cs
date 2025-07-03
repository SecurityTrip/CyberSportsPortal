using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Views;
using System.Collections.Generic;
using System.Linq;

namespace CyberSportsPortal.Core.Mappers;

public class PlayerMapper
{
    public PlayerView Map(Player player)
    {
        return new PlayerView
        {
            Id = player.Id,
            CombinedName = $"{player.Name} {player.Surname}",
            NickName = player.Nickname,
            Country = player.Country,
            TeamName = player.Team.Name,
        };
    }

    public List<PlayerView> MapList(List<Player> players)
    {
        return players.Select(x => Map(x)).ToList();
    }
}