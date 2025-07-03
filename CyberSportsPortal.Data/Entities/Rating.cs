using System;

namespace CyberSportsPortal.Data.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public DateTimeOffset AtMoment { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
