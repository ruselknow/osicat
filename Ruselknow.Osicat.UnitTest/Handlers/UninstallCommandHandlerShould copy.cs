using FluentAssertions;
using Ruselknow.Osicat.Commands;
using Ruselknow.Osicat.Handlers;
using System;
using System.Threading;
using System.Threading.Tasks;
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
        public void ThrowNotImplementException()
        {
            //act
            Func<Task<bool>> act = () => _commandHandler.Handle(new VersionCommand(), CancellationToken.None);

            //assert
            act.Should().ThrowAsync<NotImplementedException>();
        }
    }
}