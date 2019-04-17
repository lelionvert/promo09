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
            DayHours checkIns = new DayHours();

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwenty()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyOne()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 21);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateThursdayAtTwentyTwo()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 22);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateFriday()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Friday, 0);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void OneDateSaturday()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Saturday, 0);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwenty()
        {
            DayHour checkIn1 = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkIn2 = new DayHour(DayOfWeek.Thursday, 20);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndTwentyOne()
        {
            DayHour checkIn1 = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkIn2 = new DayHour(DayOfWeek.Thursday, 21);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndTwentyTwo()
        {
            DayHour checkIn1 = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkIn2 = new DayHour(DayOfWeek.Thursday, 22);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyAndFriday()
        {
            DayHour checkIn1 = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkIn2 = new DayHour(DayOfWeek.Friday, 22);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 0;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesThursdayAtTwentyOneAndTwenty()
        {
            DayHour checkIn1 = new DayHour(DayOfWeek.Thursday, 21);
            DayHour checkIn2 = new DayHour(DayOfWeek.Thursday, 20);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 1;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void TwoDatesFridayAndThursday()
        {
            DayHour checkIn1 = new DayHour(DayOfWeek.Friday, 22);
            DayHour checkIn2 = new DayHour(DayOfWeek.Thursday, 20);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 0;
            participantNumber.Should().Be(expected);
        }
        
        [TestMethod]
        public void TwoDatesThursdayAtTwentyOneAndThursdayAtTwenty()
        {
            DayHour checkIn1 = new DayHour(DayOfWeek.Thursday, 21);
            DayHour checkIn2 = new DayHour(DayOfWeek.Thursday, 21);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 2;
            participantNumber.Should().Be(expected);
        }

        [TestMethod]
        public void ThreeDatesThursdayAtTwentyOne()
        {
            DayHour checkIn1 = new DayHour(DayOfWeek.Thursday, 21);
            DayHour checkIn2 = new DayHour(DayOfWeek.Thursday, 21);
            DayHour checkIn3 = new DayHour(DayOfWeek.Thursday, 21);

            DayHours checkIns = new DayHours();
            checkIns.Add(checkIn1);
            checkIns.Add(checkIn2);
            checkIns.Add(checkIn3);

            ColdMeals coldMeals = new ColdMeals(DayOfWeek.Thursday,21,checkIns);
            int participantNumber = coldMeals.Count();

            int expected = 3;
            participantNumber.Should().Be(expected);
        }
    }
}
