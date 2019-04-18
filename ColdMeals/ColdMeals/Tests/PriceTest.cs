using System;
using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using Socrates;
using NUnit.Framework.Internal;

namespace Tests
{
    public class PriceTest
    {
        private Dictionary<Good, int> _prices;

        [SetUp]
        public void BeforeEachTest()
        {
            _prices = new Dictionary<Good, int>
            {
                { Good.SingleRoom, 610 },
                { Good.DoubleRoom, 510 },
                { Good.TripleRoom, 410 },
                { Good.NoAccomodation, 240 },
                { Good.Meal, 40 }
            };
        }
        [Test]
        public void Organisation_with_5_meals_at_40_with_no_accomodation_return_440()
        {
            Organisation organisation = new Organisation(5, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);
            Registration registration = new Registration(checkinDate, checkoutDate, Good.NoAccomodation);

            int priceForTheParticipant = organisation.CalculatePrice(registration);

            priceForTheParticipant.Should().Be(440);

        }
        [Test]
        public void Organisation_with_5_meals_at_30_with_no_accomodation_return_390()
        {
            _prices[Good.Meal] = 30;
            Organisation organisation = new Organisation(5, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);
            Registration registration = new Registration(checkinDate, checkoutDate, Good.NoAccomodation);

            int result = organisation.CalculatePrice(registration);

            result.Should().Be(390);
        }
        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_single_room_cost_850()
        {
            Organisation organisation = new Organisation(6, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);
            Registration registration = new Registration(checkinDate, checkoutDate, Good.SingleRoom);

            int result = organisation.CalculatePrice(registration);

            result.Should().Be(850);
        }

        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_double_room_cost_750()
        {
            Organisation organisation = new Organisation(6, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Good.DoubleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(750);
        }

        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_no_accomodation_cost_480()
        {
            Organisation organisation = new Organisation(6, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Good.NoAccomodation);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(480);
        }

        [Test]
        public void Arriving_friday_leaving_sunday_after_14h_with_triple_room_cost_610()
        {
            Organisation organisation = new Organisation(6, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 19);
            var checkoutDate = new DateTime(2019, 11, 21, 13, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Good.TripleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(610);
        }

        [Test]
        public void Arriving_thursday_at_18_leaving_saturday_at_20h_with_single_room_cost_810()
        {
            Organisation organisation = new Organisation(6, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 20, 20, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Good.SingleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(810);
        }

        [Test]
        public void Arriving_thursday_at_18_leaving_saturday_at_20h_with_single_room_cost_770()
        {
            Organisation organisation = new Organisation(5, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 20, 20, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Good.SingleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(770);
        }


        [Test]
        public void Arriving_friday_at_2_leaving_sunday_at_14h_with_no_accomodation_cost_440()
        {
            Organisation organisation = new Organisation(6, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 19, 2, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Good.NoAccomodation);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(440);
        }

        [Test]
        public void Arriving_thursday_at_20_leaving_sunday_at_10h_with_no_accomodation_cost_440()
        {
            Organisation organisation = new Organisation(6, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 18, 20, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 10, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Good.NoAccomodation);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(440);
        }

        [Test]
        public void Arriving_friday_at_1h_leaving_saturday_at_18h_with_double_room_return_670()
        {
            Organisation organisation = new Organisation(6, new DateTime(2019, 11, 19, 00, 00, 00), new DateTime(2019, 11, 21, 12, 00, 00), _prices);
            var checkinDate = new DateTime(2019, 11, 19, 1, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 20, 18, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Good.DoubleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(670);


        }
    }
}