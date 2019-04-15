using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocratesFrance;
using FluentAssertions;

namespace SocratesFranceTest
{
    [TestClass]
    public class ParticipantTest
    {
        [TestMethod]
        public void ParticipantDoesNotHaveACheckIn()
        {
            Participant participant = new Participant();

            participant.HasCheckin().Should().BeFalse();
        }

        [TestMethod]
        public void ParticipantShouldHaveACheckIn()
        {
            CheckIn checkIn = new CheckIn(DayOfWeek.Thursday,20);
            Participant participant = new Participant(checkIn);

            participant.HasCheckin().Should().BeTrue();
        }


    }
}
