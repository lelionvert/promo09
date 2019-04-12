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
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            int participantNumber = ColdMeals.GetParticipantNumber(checkIn);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyOne()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);
            int participantNumber = ColdMeals.GetParticipantNumber(checkIn);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyTwo()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Thursday, 22);
            int participantNumber = ColdMeals.GetParticipantNumber(checkIn);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateFriday()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Friday, 0);
            int participantNumber = ColdMeals.GetParticipantNumber(checkIn);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }
        [TestMethod]
        public void OneDateSaturday()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Saturday, 0);
            int participantNumber = ColdMeals.GetParticipantNumber(checkIn);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwenty()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);

            int participantNumber = ColdMeals.GetParticipantNumber(checkIn1, checkIn2);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndTwentyOne()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);

            int participantNumber = ColdMeals.GetParticipantNumber(checkIn1, checkIn2);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }
    }

}
