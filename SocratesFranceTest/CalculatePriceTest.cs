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

        readonly DateTime THURSDAY_EVENING = new DateTime(2019, 4, 25, 20, 0, 0);
        readonly DateTime THURSDAY_LATE_EVENING = new DateTime(2019, 4, 25, 22, 0, 0);
        readonly DateTime SUNDAY_MORNING = new DateTime(2019, 4, 28, 11, 0, 0);
        readonly DateTime SUNDAY_AFTERNOON = new DateTime(2019, 4, 28, 14, 0, 0);

        readonly static DateTime SESSION_START_TIME = new DateTime(2019, 4, 25, 21, 0, 0);
        readonly static DateTime SESSION_END_TIME = new DateTime(2019, 4, 28, 12, 0, 0);

        SocratesOrganizer socratesOrganizer = new SocratesOrganizer(SESSION_START_TIME, SESSION_END_TIME);

        [TestMethod]
        public void CompletePriceSingleTest()
        {
            DayHour checkIn = new DayHour(THURSDAY_EVENING);
            DayHour checkOut = new DayHour(SUNDAY_AFTERNOON);
            Registration registration = new Registration(Room.SINGLE_ACCOMMODATION, checkIn, checkOut);
            Billing billing = new Billing();

            int price = billing.ComputeTotalPriceForRegistration(registration, socratesOrganizer.ComputeMealCount(registration));

            int expected = 610 + 6 * 40;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceDoubleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 20, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Registration registration = new Registration(Room.DOUBLE_ACCOMMODATION, checkIn, checkOut);
            Billing billing = new Billing();

            int price = billing.ComputeTotalPriceForRegistration(registration, socratesOrganizer.ComputeMealCount(registration));

            int expected = 750;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceTripleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 20, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Registration registration = new Registration(Room.TRIPLE_ACCOMMODATION, checkIn, checkOut);
            Billing billing = new Billing();

            int price = billing.ComputeTotalPriceForRegistration(registration, socratesOrganizer.ComputeMealCount(registration));

            int expected = 650;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void CompletePriceNoAccomodationTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 20, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Registration registration = new Registration(Room.NO_ACCOMMODATION, checkIn, checkOut);
            Billing billing = new Billing();

            int price = billing.ComputeTotalPriceForRegistration(registration, socratesOrganizer.ComputeMealCount(registration));

            int expected = 480;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void PriceWithoutOneMealChekcInFridaySingleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 21, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 14, 0, 0));
            Registration registration = new Registration(Room.SINGLE_ACCOMMODATION, checkIn, checkOut);
            Billing billing = new Billing();

            int price = billing.ComputeTotalPriceForRegistration(registration, socratesOrganizer.ComputeMealCount(registration));

            int expected = 810;
            price.Should().Be(expected);
        }
        
        [TestMethod]
        public void PriceWithoutOneMealCheckOutBeforeSundayAtTwelveSingleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 25, 20, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 28, 11, 0, 0));
            Registration registration = new Registration(Room.SINGLE_ACCOMMODATION, checkIn, checkOut);
            Billing billing = new Billing();

            int price = billing.ComputeTotalPriceForRegistration(registration, socratesOrganizer.ComputeMealCount(registration));

            int expected = 810;
            price.Should().Be(expected);
        }

        [TestMethod]
        public void PriceWithoutTwoMealsCheckOutBeforeSaturdayAtEigthteenSingleTest()
        {
            DayHour checkIn = new DayHour(new DateTime(2019, 04, 26, 12, 0, 0));
            DayHour checkOut = new DayHour(new DateTime(2019, 04, 27, 18, 0, 0));
            Registration registration = new Registration(Room.SINGLE_ACCOMMODATION, checkIn, checkOut);
            Billing billing = new Billing();

            int price = billing.ComputeTotalPriceForRegistration(registration, socratesOrganizer.ComputeMealCount(registration));

            int expected = 770;
            price.Should().Be(expected);
        }
    }
}
