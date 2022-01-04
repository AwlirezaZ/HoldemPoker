using Domain;
using FluentAssertions;
using System;
using Xunit;

namespace HoldemPoker.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void add_a_player_and_name_it()
        {
            var playerName = "Jack";

            var player = new Player(playerName);

            player.PlayerName.Should().Be(playerName);
        }
    }
}
