using System;
using NUnit.Framework;
using FluentAssertions;
using ColdMeals;

namespace Tests
{
    public class PriceTest
    {
        [Test]
        public void Organisation_with_5_meals_at_40_with_no_accomodation_return_440()
        {
            Organisation organisation = new Organisation(5, 40);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);
            Participant participant = new Participant(checkinDate, checkoutDate, AccomodationChoice.NoAccomodation);

            int result = organisation.CalculatePrice(participant);

            result.Should().Be(440);

        }
        [Test]
        public void Organisation_with_5_meals_at_30_with_no_accomodation_return_390()
        {
            Organisation organisation = new Organisation(5, 30);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);
            Participant participant = new Participant(checkinDate, checkoutDate, AccomodationChoice.NoAccomodation);

            int result = organisation.CalculatePrice(participant);

            result.Should().Be(390);

        }
        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_single_room_cost_850()
        {
            Organisation organisation = new Organisation(6,40);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);
            Participant participant = new Participant(checkinDate, checkoutDate, AccomodationChoice.Single);

            int result = organisation.CalculatePrice(participant);

            result.Should().Be(850);
        }

        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_double_room_cost_750()
        {
            Organisation organisation = new Organisation(6, 40);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Participant participant = new Participant(checkinDate, checkoutDate, AccomodationChoice.Double);
            int result = organisation.CalculatePrice(participant);

            result.Should().Be(750);
        }

        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_no_accomodation_cost_480()
        {
            Organisation organisation = new Organisation(6, 40);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Participant participant = new Participant(checkinDate, checkoutDate, AccomodationChoice.NoAccomodation);
            int result = organisation.CalculatePrice(participant);

            result.Should().Be(480);
        }
    }
}