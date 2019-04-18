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
            DayHour checkIn = new DayHour(new DateTime(2019, 4, 25, 20, 0, 0));
            Participant participant = new Participant(checkIn);

            participant.HasCheckin().Should().BeTrue();
        }
    }
}
