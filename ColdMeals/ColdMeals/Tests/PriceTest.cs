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
        private Dictionary<Room, int> _prices;
        private Period _mealsLimitPeriod = new Period(
            new DateTime(2019, 11, 18, 23, 59, 59),
            new DateTime(2019, 11, 21, 12, 00, 00)
            );

        [SetUp]
        public void BeforeEachTest()
        {
            _prices = new Dictionary<Room, int>
            {
                { Room.SingleRoom, 610 },
                { Room.DoubleRoom, 510 },
                { Room.TripleRoom, 410 },
                { Room.NoAccomodation, 240 }
            };
        }

        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_single_room_cost_850()
        {
            Organisation organisation = new Organisation(40, _prices, _mealsLimitPeriod);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);
            Registration registration = new Registration(checkinDate, checkoutDate, Room.SingleRoom);

            int result = organisation.CalculatePrice(registration);

            result.Should().Be(850);
        }

        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_double_room_cost_750()
        {
            Organisation organisation = new Organisation(40, _prices, _mealsLimitPeriod);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Room.DoubleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(750);
        }

        [Test]
        public void Complete_price_arriving_thursday_before_21_leaving_sunday_after_14h_with_no_accomodation_cost_480()
        {
            Organisation organisation = new Organisation(40, _prices, _mealsLimitPeriod);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Room.NoAccomodation);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(480);
        }

        [Test]
        public void Arriving_friday_leaving_sunday_after_14h_with_triple_room_cost_610()
        {
            Organisation organisation = new Organisation(40, _prices, _mealsLimitPeriod);
            var checkinDate = new DateTime(2019, 11, 19);
            var checkoutDate = new DateTime(2019, 11, 21, 13, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Room.TripleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(610);
        }

        [Test]
        public void Arriving_thursday_at_18_leaving_saturday_at_20h_with_single_room_cost_810()
        {
            Organisation organisation = new Organisation(40, _prices, _mealsLimitPeriod);
            var checkinDate = new DateTime(2019, 11, 18, 18, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 20, 20, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Room.SingleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(810);
        }


        [Test]
        public void Arriving_friday_at_2_leaving_sunday_at_14h_with_no_accomodation_cost_440()
        {
            Organisation organisation = new Organisation(40, _prices, _mealsLimitPeriod);
            var checkinDate = new DateTime(2019, 11, 19, 2, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 14, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Room.NoAccomodation);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(440);
        }

        [Test]
        public void Arriving_thursday_at_20_leaving_sunday_at_10h_with_no_accomodation_cost_440()
        {
            Organisation organisation = new Organisation(40, _prices, _mealsLimitPeriod);
            var checkinDate = new DateTime(2019, 11, 18, 20, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 21, 10, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Room.NoAccomodation);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(440);
        }

        [Test]
        public void Arriving_friday_at_1h_leaving_saturday_at_18h_with_double_room_return_670()
        {
            Organisation organisation = new Organisation(40, _prices, _mealsLimitPeriod);
            var checkinDate = new DateTime(2019, 11, 19, 1, 00, 00);
            var checkoutDate = new DateTime(2019, 11, 20, 18, 00, 00);

            Registration registration = new Registration(checkinDate, checkoutDate, Room.DoubleRoom);
            int result = organisation.CalculatePrice(registration);

            result.Should().Be(670);
        }
    }
}