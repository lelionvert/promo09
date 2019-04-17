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
            Participant participant = new Participant(checkIn, checkOut, Accommodation.SINGLE);

            int price = participant.ComputeTotalPrice();

            int expected = 610 + 6 * 40;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceDoubleTest()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkOut = new DayHour(DayOfWeek.Sunday, 14);
            Participant participant = new Participant(checkIn, checkOut,Accommodation.DOUBLE);

            int price = participant.ComputeTotalPrice();

            int expected = 750;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceTripleTest()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkOut = new DayHour(DayOfWeek.Sunday, 14);
            Participant participant = new Participant(checkIn, checkOut, Accommodation.TRIPLE);

            int price = participant.ComputeTotalPrice();

            int expected = 650;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceNoAccomodationTest()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkOut = new DayHour(DayOfWeek.Sunday, 14);
            Participant participant = new Participant(checkIn, checkOut, Accommodation.NO_ACCOMODATION);

            int price = participant.ComputeTotalPrice();

            int expected = 480;
            price.Should().Be(expected);
        }

    }
}
