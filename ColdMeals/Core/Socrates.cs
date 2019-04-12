using System;
using System.Collections.Generic;

namespace ColdMeals.Core
{
    public class Socrates
    {
        public readonly List<Participant> Participants;

        public Socrates()
        {
            Participants = new List<Participant>();
        }

        public void AddParticipant(string name, DateTime? arrivedDate)
        {
            Participant participant = Participant.CreateParticipant(name, arrivedDate);
            Participants.Add(participant);
        }

        public int CountNumberOfColdMeats()
        {
            return 0;
        }
    }
}