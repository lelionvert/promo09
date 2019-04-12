using System;
using NUnit.Framework;
using FluentAssertions;
using ColdMeals.Core;

namespace Tests
{
    public class SocratesTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Participant_list_is_not_null()
        {
            Socrates socrates = new Socrates();

            socrates.Participants.Should().NotBeNull();
        }

    }
}