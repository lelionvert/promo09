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
            Socrates socrates = new Socrates();
            socrates.Participants.Should().NotBeNull();
        }

        [Test]
        public void Add_participant_to_the_participant_list_return_not_null_or_empty_list()
        {
            Socrates socrates = new Socrates();

            socrates.AddParticipant("Sandy", new DateTime(2019, 11, 18, 18, 00, 00));
            socrates.Participants.Should().NotBeNullOrEmpty();
        }
    }
}