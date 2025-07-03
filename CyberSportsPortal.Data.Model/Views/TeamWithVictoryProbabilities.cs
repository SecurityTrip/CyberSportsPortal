using System.Collections.Generic;

namespace CyberSportsPortal.Data.Model.Views
{
    public class TeamWithVictoryProbabilities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Dictionary<int, int> VictoryProbabilities { get; }

        public TeamWithVictoryProbabilities(int id, string name, Dictionary<int, int> probabilities)
        {
            Id = id;
            Name = name;
            VictoryProbabilities = probabilities;
        }

        public int GetVictoryProbability(int teamId)
        {
            return VictoryProbabilities[teamId];
        }
    }
}
