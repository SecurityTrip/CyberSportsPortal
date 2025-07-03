namespace CyberSportsPortal.Data.Entities
{
    public class ProbabilityOfVictory
    {
        public int Id { get; set; }
        public int WinnerId { get; set; }
        public int LoserId { get; set; }
        public int Probability { get; set; }
        public virtual Team Winner { get; set; }
        public virtual Team Loser { get; set; }
    }
}
