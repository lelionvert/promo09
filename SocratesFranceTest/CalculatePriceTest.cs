using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocratesFrance;

namespace SocratesFranceTest
{
    [TestClass]
    public class CalculatePriceTest
    {
        Priceable singleAccommodation = new Priceable(610);
        Priceable doubleAccommodation = new Priceable(510);
        Priceable tripleAccommodation = new Priceable(410);
        Priceable noAccommodation = new Priceable(240);
        Priceable meal = new Priceable(40);

        [TestMethod]
        public void CompletePriceSingleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019,04,25,20,0,0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Participant participant = new Participant(checkIn, checkOut, singleAccommodation);
            Pricing pricing = new Pricing(meal);

            int price = pricing.ComputeTotalPrice(participant);

            int expected = 610 + 6 * 40;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceDoubleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 20, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Participant participant = new Participant(checkIn, checkOut, doubleAccommodation);
            Pricing pricing = new Pricing(meal);

            int price = pricing.ComputeTotalPrice(participant);

            int expected = 750;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceTripleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 20, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Participant participant = new Participant(checkIn, checkOut, tripleAccommodation);
            Pricing pricing = new Pricing(meal);

            int price = pricing.ComputeTotalPrice(participant);

            int expected = 650;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceNoAccomodationTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 20, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Participant participant = new Participant(checkIn, checkOut, noAccommodation);
            Pricing pricing = new Pricing(meal);

            int price = pricing.ComputeTotalPrice(participant);

            int expected = 480;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void PriceWithoutOneMealChekcInFridaySingleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 21, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Participant participant = new Participant(checkIn, checkOut, singleAccommodation);
            Pricing pricing = new Pricing(meal);

            int price = pricing.ComputeTotalPrice(participant);

            int expected = 810;
            price.Should().Be(expected);
        }
        
        [TestMethod]
        public void PriceWithoutOneMealCheckOutBeforeSundayAtTwelveSingleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 20, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 11, 0, 0));
            Participant participant = new Participant(checkIn, checkOut, singleAccommodation);
            Pricing pricing = new Pricing(meal);

            int price = pricing.ComputeTotalPrice(participant);

            int expected = 810;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void PriceWithoutTwoMealsCheckOutBeforeSaturdayAtEigthteenSingleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 26, 12, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 27, 18, 0, 0));
            Participant participant = new Participant(checkIn, checkOut, singleAccommodation);
            Pricing pricing = new Pricing(meal);

            int price = pricing.ComputeTotalPrice(participant);

            int expected = 770;
            price.Should().Be(expected);
        }
    }
}
