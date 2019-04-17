using System;
using NUnit.Framework;
using FluentAssertions;
using ColdMeals;

namespace Tests
{
    public class CheckinTest
    {

        [Test]
        public void Checkin_is_between_two_differentes_dates()
        {
            Checkin checkin = Checkin.CreateCheckin(new DateTime(2019, 11, 18, 21, 00, 00));

            bool result = checkin.IsArrivingBetween(new DateTime(2019, 11, 18), new DateTime(2019, 11, 19));

            result.Should().BeTrue();
        }

        [Test]
        public void Checkin_is_between_same_date_with_differents_hours()
        {
            Checkin checkin = Checkin.CreateCheckin(new DateTime(2019, 11, 18, 21, 00, 00));

            bool result = checkin.IsArrivingBetween(new DateTime(2019, 11, 18, 15, 00, 00), new DateTime(2019, 11, 18, 22, 00, 00));

            result.Should().BeTrue();
        }
    }

}
