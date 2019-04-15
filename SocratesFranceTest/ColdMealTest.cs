using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using SocratesFrance;
using System.Collections.Generic;

namespace SocratesFranceTest
{
    [TestClass]
    public class ColdMealTest
    {
        [TestMethod]
        public void ZeroDateReturnZeroParticipant()
        {
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwenty()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyOne()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyTwo()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Thursday, 22);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateFriday()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Friday, 0);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateSaturday()
        {
            ColdMeals.CheckIn checkIn = new ColdMeals.CheckIn(DayOfWeek.Saturday, 0);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwenty()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndTwentyOne()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndTwentyTwo()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 22);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndFriday()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Friday, 22);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyOneAndTwenty()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesFridayAndThursday()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Friday, 22);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 20);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }
        
        [TestMethod]
        public void TwoDatesThursdayAtTwentyOneAndThursdayAtTwenty()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);
            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 2;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void ThreeDatesThursdayAtTwentyOne()
        {
            ColdMeals.CheckIn checkIn1 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);
            ColdMeals.CheckIn checkIn2 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);
            ColdMeals.CheckIn checkIn3 = new ColdMeals.CheckIn(DayOfWeek.Thursday, 21);

            List<ColdMeals.CheckIn> checkIns = new List<ColdMeals.CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);
            checkIns.Add(checkIn3);

            ColdMeals coldMeals = new ColdMeals();
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 3;
            participantNumber.Should().Be(expected);
        }
    }

}
