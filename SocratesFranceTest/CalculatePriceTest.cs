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
        public void CompletePriceTest()
        {
            CheckIn checkIn = new CheckIn(DayOfWeek.Thursday, 20);
            CheckIn checkOut = new CheckIn(DayOfWeek.Sunday, 14);
            Participant participant = new Participant(checkIn, checkOut);

            int price = participant.ComputeTotalPrice();

            int expected = 850;
            price.Should().Be(expected);
        }
    }
}
