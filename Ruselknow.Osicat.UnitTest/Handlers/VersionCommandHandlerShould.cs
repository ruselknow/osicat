using FluentAssertions;
using Ruselknow.Osicat.Commands;
using Ruselknow.Osicat.Handlers;
using System.Threading;
using Xunit;

namespace Ruselknow.Osicat.UnitTest.Handlers
{
    public class VersionCommandHandlerShould
    {
        private readonly VersionCommandHandler _commandHandler;

        public VersionCommandHandlerShould()
        {
            _commandHandler = new VersionCommandHandler();
        }

        [Fact]
        public void ReturnTrue()
        {
            //act
            var result = _commandHandler.Handle(new VersionCommand(), CancellationToken.None);

            //assert
            result.Should().NotBeNull();
            result.Result.Should().BeTrue();
        }
    }
}