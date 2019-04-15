using System;
using System.Collections.Generic;

namespace ColdMeals.Core
{
    public class Socrates
    {
        public readonly List<Participant> Participants;
        private readonly DateTime _startDate;

        public Socrates(DateTime startedDate)
        {
            Participants = new List<Participant>();
            _startDate = startedDate;
        }

        public void AddParticipant(string name, DateTime? arrivedDate)
        {
            Participant participant = Participant.CreateParticipant(name, arrivedDate);
            Participants.Add(participant);
        }

        public int CountNumberOfColdMeals()
        {
            int count = 0;
            foreach (Participant participant in Participants)
            {
                if (participant.IsArrivingAfter21hTheStartDay(_startDate)) count++;
            }
            return count;
        }
    }
}