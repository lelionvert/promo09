using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace SocratesFranceTest
{
    [TestClass]
    public class ColdMealTest
    {
        [TestMethod]
        public void ZeroDateReturnZeroParticipant()
        {
            int participantNumber = ColdMeals.GetParticipantNumber();

            int expected = 0;
            participantNumber.Should().Be(expected);
        }
    }
}
