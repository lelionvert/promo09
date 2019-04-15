using System;
using NUnit.Framework;
using FluentAssertions;
using ColdMeals.Core;

namespace Tests
{
    public class ParticipantTest
    {
        [Test]
        public void Participant_who_arrive_to_the_good_date_should_return_true()
        {
            Checkin participant = Checkin.CreateCheckin(new DateTime(2019, 11, 18, 17, 00, 00));

            bool result = participant.IsArrivingTheStartDay(new DateTime(2019, 11, 18, 21, 00, 00));

            result.Should().BeTrue();
        }

        [Test]
        public void Participant_who_arrive_before_twenty_one_hour_return_false()
        {
            Checkin participant = Checkin.CreateCheckin(new DateTime(2019, 11, 18, 17, 00, 00));

            bool result = participant.IsArrivingAfter21hTheStartDay(new DateTime(2019, 11, 18, 21, 00, 00));

            result.Should().BeFalse();
        }

        [Test]
        public void Participant_who_not_arrived_return_false()
        {
            Checkin participant = Checkin.CreateCheckin(null);

            bool result = participant.IsArrivingAfter21hTheStartDay(new DateTime(2019, 11, 18, 21, 00, 00));

            result.Should().BeFalse();
        }

        [Test]
        public void Participant_who_arrive_between_twenty_one_hour_and_midnight_return_true()
        {
            Checkin participant = Checkin.CreateCheckin(new DateTime(2019, 11, 18, 21, 00, 00));

            bool result = participant.IsArrivingAfter21hTheStartDay(new DateTime(2019, 11, 18, 21, 00, 00));

            result.Should().BeTrue();
        }

        [Test]
        public void Participant_who_arrive_at_twenty_one_hour_return_true()
        {
            Checkin participant = Checkin.CreateCheckin(new DateTime(2019, 11, 18, 21, 00, 00));

            bool result = participant.IsArrivingAfter21hTheStartDay(new DateTime(2019, 11, 18, 21, 00, 00));

            result.Should().BeTrue();
        }
    }
}