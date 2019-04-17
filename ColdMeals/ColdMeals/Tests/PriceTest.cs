using System;
using NUnit.Framework;
using FluentAssertions;
using ColdMeals.Core;

namespace Tests
{
    public class PriceTest
    {
        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_single_room_cost_850()
        {
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Participant participant = new Participant(checkinDate, checkoutDate, AccomodationChoice.Single);

            int result = participant.CalculatePrice();

            result.Should().Be(850);
        }

        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_double_room_cost_750()
        {
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Participant participant = new Participant(checkinDate, checkoutDate, AccomodationChoice.Double);

            int result = participant.CalculatePrice();

            result.Should().Be(750);
        }
    }
}