using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocratesFrance;

namespace SocratesFranceTest
{
    [TestClass]
    public class CalculatePriceTest
    {
        [TestMethod]
        public void CompletePriceSingleTest()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkOut = new DayHour(DayOfWeek.Sunday, 14);
            Participant participant = new Participant(checkIn, checkOut, Choice.SINGLE);

            int price = participant.ComputeTotalPrice();

            int expected = 610 + 6 * 40;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceDoubleTest()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkOut = new DayHour(DayOfWeek.Sunday, 14);
            Participant participant = new Participant(checkIn, checkOut,Choice.DOUBLE);

            int price = participant.ComputeTotalPrice();

            int expected = 750;
            price.Should().Be(expected);

        }
    }
}
