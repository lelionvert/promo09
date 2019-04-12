using System.Collections.Generic;

namespace ColdMeals.Core
{
    public class Socrates
    {
        public List<Participant> Participants { get; set; }
        public Socrates()
        {
            Participants = new List<Participant>();
        }
    }
}