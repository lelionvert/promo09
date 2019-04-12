using System;

namespace Tests
{
    internal class Participant
    {
        private string _name;
        private DateTime _arrivedDate;

        public Participant(string name, DateTime arrivedDate)
        {
            this._name = name;
            this._arrivedDate = arrivedDate;
        }

        internal bool IsArrivingTheStartDay()
        {
            return this._arrivedDate < new DateTime(2019, 11, 19);
        }

        internal bool IsArrivingBefore21h()
        {
            return true;
        }
    }
}