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
        public void ParticipantShouldHaveACheckIn()
        {
            Participant participant = new Participant();

            participant.HasCheckin().Should().BeTrue();
        }
    }
}
