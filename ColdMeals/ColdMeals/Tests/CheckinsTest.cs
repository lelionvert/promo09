using System;
using NUnit.Framework;
using FluentAssertions;
using ColdMeals.Core;

namespace Tests
{
    public class CheckinsTest
    {
        [Test]
        public void Count_number_between_2_dates_return_0()
        {
            var startedDate = new DateTime(2019, 11, 18);
            var coldMealStartDate = new DateTime(2019, 11, 18, 21, 00, 00);
            Checkins socrates = new Checkins();

            socrates.AddCheckin(null);
            socrates.AddCheckin(new DateTime(2019, 11, 18, 20, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 19, 22, 00, 00));

            int result = socrates.CountBetween(coldMealStartDate, startedDate.Date.AddDays(1));

            result.Should().Be(0);
        }
        [Test]
        public void Count_number_between_2_dates_return_1()
        {
            var startedDate = new DateTime(2019, 11, 18);
            var coldMealStartDate = new DateTime(2019, 11, 18, 21, 00, 00);
            Checkins socrates = new Checkins();
            socrates.AddCheckin(new DateTime(2019, 11, 19, 00, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 20, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 22, 00, 00));

            int result = socrates.CountBetween(coldMealStartDate, startedDate.Date.AddDays(1));

            result.Should().Be(1);
        }

        [Test]
        public void Count_number_between_2_dates_return_2()
        {
            var startedDate = new DateTime(2019, 11, 18);
            var coldMealStartDate = new DateTime(2019, 11, 18, 21, 00, 00);
            Checkins socrates = new Checkins();
            socrates.AddCheckin(new DateTime(2019, 11, 18, 23, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 23, 59, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 10, 00, 00));

            int result = socrates.CountBetween(coldMealStartDate, startedDate.Date.AddDays(1));

            result.Should().Be(2);
        }
    }
}