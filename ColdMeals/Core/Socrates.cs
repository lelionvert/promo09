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

        public void AddParticipant(string v, DateTime dateTime)
        {
            Participant participant = new Participant(v, dateTime);
            Participants.Add(participant);
        }
    }
}