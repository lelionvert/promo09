using System;
using NUnit.Framework;
using FluentAssertions;
using ColdMeals.Core;

namespace Tests
{
    public class SocratesTest
    {

        [Test]
        public void Participant_list_is_not_null()
        {
            Socrates socrates = new Socrates(new DateTime(2019, 11, 18, 21, 00, 00));
            socrates.Checkins.Should().NotBeNull();
        }

        [Test]
        public void Add_participant_to_the_participant_list_return_not_null_or_empty_list()
        {
            Socrates socrates = new Socrates(new DateTime(2019, 11, 18, 21, 00, 00));

            socrates.AddCheckin(new DateTime(2019, 11, 18, 18, 00, 00));

            socrates.Checkins.Should().NotBeNullOrEmpty();
        }

        [Test]
        public void Count_participants_number_who_arrived_after_or_at_21_returns_0()
        {
            Socrates socrates = new Socrates(new DateTime(2019, 11, 18, 21, 00, 00));
            socrates.AddCheckin(null);
            socrates.AddCheckin(new DateTime(2019, 11, 18, 20, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 19, 22, 00, 00));

            int result = socrates.CountNumberOfColdMeals();

            result.Should().Be(0);
        }
        [Test]
        public void Count_participants_number_who_arrived_after_or_at_21_returns_1()
        {
            Socrates socrates = new Socrates(new DateTime(2019, 11, 18, 21, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 19, 00, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 20, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 22, 00, 00));

            int result = socrates.CountNumberOfColdMeals();

            result.Should().Be(1);
        }

        [Test]
        public void Count_participants_number_who_arrived_after_or_at_21_returns_2()
        {
            Socrates socrates = new Socrates(new DateTime(2019, 11, 18, 21, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 23, 00, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 23, 59, 00));
            socrates.AddCheckin(new DateTime(2019, 11, 18, 10, 00, 00));

            int result = socrates.CountNumberOfColdMeals();

            result.Should().Be(2);
        }
    }
}