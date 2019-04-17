using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocratesFrance;
using static SocratesFrance.Accommodation;

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
            Accommodation accommadation = new Accommodation(AccommodationEnum.SINGLE, 610);
            Participant participant = new Participant(checkIn, checkOut, accommadation);

            int price = participant.ComputeTotalPrice();

            int expected = 610 + 6 * 40;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceDoubleTest()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkOut = new DayHour(DayOfWeek.Sunday, 14);
            Accommodation accommodation = new Accommodation(AccommodationEnum.DOUBLE, 510);
            Participant participant = new Participant(checkIn, checkOut,accommodation);

            int price = participant.ComputeTotalPrice();

            int expected = 750;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceTripleTest()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkOut = new DayHour(DayOfWeek.Sunday, 14);
            Accommodation accommodation = new Accommodation(AccommodationEnum.TRIPLE, 410);
            Participant participant = new Participant(checkIn, checkOut, accommodation);

            int price = participant.ComputeTotalPrice();

            int expected = 650;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceNoAccomodationTest()
        {
            DayHour checkIn = new DayHour(DayOfWeek.Thursday, 20);
            DayHour checkOut = new DayHour(DayOfWeek.Sunday, 14);
            Accommodation accommodation = new Accommodation(AccommodationEnum.NO_ACCOMODATION, 240);
            Participant participant = new Participant(checkIn, checkOut, accommodation);

            int price = participant.ComputeTotalPrice();

            int expected = 480;
            price.Should().Be(expected);
        }

    }
}
