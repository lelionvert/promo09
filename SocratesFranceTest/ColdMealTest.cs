using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using SocratesFrance;

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

        [TestMethod]
        public void OneDateThursdayAtTwenty()
        {
            int participantNumber = ColdMeals.GetParticipantNumber(DayOfWeek.Thursday, 20);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyOne()
        {
            int participantNumber = ColdMeals.GetParticipantNumber(DayOfWeek.Thursday, 21);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyTwo()
        {
            int participantNumber = ColdMeals.GetParticipantNumber(DayOfWeek.Thursday, 22);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateFriday()
        {
            int participantNumber = ColdMeals.GetParticipantNumber(DayOfWeek.Friday,0);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }
        [TestMethod]
        public void OneDateSaturday()
        {
            int participantNumber = ColdMeals.GetParticipantNumber(DayOfWeek.Saturday,0);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }
    }

}
