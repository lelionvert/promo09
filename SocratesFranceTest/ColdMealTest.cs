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
            List<CheckIn> checkIns = new List<CheckIn>();

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwenty()
        {
            CheckIn checkIn = new CheckIn(DayOfWeek.Thursday, 20);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyOne()
        {
            CheckIn checkIn = new CheckIn(DayOfWeek.Thursday, 21);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyTwo()
        {
            CheckIn checkIn = new CheckIn(DayOfWeek.Thursday, 22);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateFriday()
        {
            CheckIn checkIn = new CheckIn(DayOfWeek.Friday, 0);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateSaturday()
        {
            CheckIn checkIn = new CheckIn(DayOfWeek.Saturday, 0);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwenty()
        {
            CheckIn checkIn1 = new CheckIn(DayOfWeek.Thursday, 20);
            CheckIn checkIn2 = new CheckIn(DayOfWeek.Thursday, 20);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndTwentyOne()
        {
            CheckIn checkIn1 = new CheckIn(DayOfWeek.Thursday, 20);
            CheckIn checkIn2 = new CheckIn(DayOfWeek.Thursday, 21);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndTwentyTwo()
        {
            CheckIn checkIn1 = new CheckIn(DayOfWeek.Thursday, 20);
            CheckIn checkIn2 = new CheckIn(DayOfWeek.Thursday, 22);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndFriday()
        {
            CheckIn checkIn1 = new CheckIn(DayOfWeek.Thursday, 20);
            CheckIn checkIn2 = new CheckIn(DayOfWeek.Friday, 22);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyOneAndTwenty()
        {
            CheckIn checkIn1 = new CheckIn(DayOfWeek.Thursday, 21);
            CheckIn checkIn2 = new CheckIn(DayOfWeek.Thursday, 20);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesFridayAndThursday()
        {
            CheckIn checkIn1 = new CheckIn(DayOfWeek.Friday, 22);
            CheckIn checkIn2 = new CheckIn(DayOfWeek.Thursday, 20);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 0;
            participantNumber.Should().Be(expected);
        }
        
        [TestMethod]
        public void TwoDatesThursdayAtTwentyOneAndThursdayAtTwenty()
        {
            CheckIn checkIn1 = new CheckIn(DayOfWeek.Thursday, 21);
            CheckIn checkIn2 = new CheckIn(DayOfWeek.Thursday, 21);
            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 2;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void ThreeDatesThursdayAtTwentyOne()
        {
            CheckIn checkIn1 = new CheckIn(DayOfWeek.Thursday, 21);
            CheckIn checkIn2 = new CheckIn(DayOfWeek.Thursday, 21);
            CheckIn checkIn3 = new CheckIn(DayOfWeek.Thursday, 21);

            List<CheckIn> checkIns = new List<CheckIn>();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);
            checkIns.Add(checkIn3);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21);
            int participantNumber = coldMeals.GetNumber(checkIns);

            int expected = 3;
            participantNumber.Should().Be(expected);
        }
    }

}
