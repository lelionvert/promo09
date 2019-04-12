using System;

namespace Tests
{
    internal class Participant
    {
        private string v;
        private DateTime dateTime;

        public Participant(string v, DateTime dateTime)
        {
            this.v = v;
            this.dateTime = dateTime;
        }

        internal bool IsArrivingTheStartDay()
        {
            return true;
        }
    }
}