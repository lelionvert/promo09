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
            Participant participant = Participant.CreateParticipant("Florian", new DateTime(2019,11,18,17,00,00));

            bool result = participant.IsArrivingTheStartDay();

            result.Should().BeTrue();
        }

        [Test]
        public void Participant_who_arrive_before_twenty_one_hour_return_true()
        {
            Participant participant = Participant.CreateParticipant("Florian", new DateTime(2019, 11, 18, 17, 00, 00));

            bool result = participant.IsArrivingBeforeOrAt21h();

            result.Should().BeTrue();
        }

        [Test]
        public void Participant_who_arrive_at_twenty_one_hour_return_true()
        {
            Participant participant = Participant.CreateParticipant("Florian", new DateTime(2019, 11, 18, 21, 00, 00));

            bool result = participant.IsArrivingBeforeOrAt21h();

            result.Should().BeTrue();
        }
    }
}