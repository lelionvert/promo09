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
        public void participant_who_arrive_to_the_good_date_should_return_true()
        {
            Participant participant = new Participant("Florian", new DateTime(2019,11,18,17,00,00));

            bool result = participant.IsArrivingTheStartDay();

            result.Should().BeTrue();

        }
    }
}