using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSportsPortal.Core.Mappers;

public class TeamMapper
{
    public TeamWithVictoryProbabilities Map(Team team, List<ProbabilityOfVictory> probabilities)
    {
        var probabilitiesDictionary = new Dictionary<int, int>();
        foreach (var probability in probabilities)
        {
            if(probability.WinnerId == team.Id)
            {
                probabilitiesDictionary.Add(probability.LoserId, probability.Probability);
            }
            else
            {
                probabilitiesDictionary.Add(probability.WinnerId, 100 - probability.Probability);
            }
        }

        return new TeamWithVictoryProbabilities(team.Id, team.Name, probabilitiesDictionary);
    }
}