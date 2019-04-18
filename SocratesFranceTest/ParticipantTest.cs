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
            Registration participant = new Registration();

            participant.HasCheckin().Should().BeFalse();
        }

        [TestMethod]
        public void ParticipantShouldHaveACheckIn()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 4, 25, 20, 0, 0));
            Registration participant = new Registration(checkIn);

            participant.HasCheckin().Should().BeTrue();
        }
    }
}
