using System;
using NUnit.Framework;
using FluentAssertions;
namespace Tests
{
    public class ParticipantTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Participant_who_arrive_to_the_good_date_should_return_true()
        {
            Participant participant = new Participant("Florian", new DateTime(2019,11,18,17,00,00));

            bool result = participant.IsArrivingTheStartDay();

            result.Should().BeTrue();
        }

        [Test]
        public void Participant_who_arrive_before_twenty_one_hour_return_true()
        {
            Participant participant = new Participant("Florian", new DateTime(2019, 11, 18, 17, 00, 00));

            bool result = participant.IsArrivingBefore21h();

            result.Should().BeTrue();
        }

        [Test]
        public void Participant_who_arrive_at_twenty_one_hour_return_true()
        {
            Participant participant = new Participant("Florian", new DateTime(2019, 11, 18, 21, 00, 00));

            bool result = participant.IsArrivingBefore21h();

            result.Should().BeTrue();
        }

    }
}