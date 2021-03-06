using FluentAssertions;
using Ruselknow.Osicat.Commands;
using Ruselknow.Osicat.Handlers;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Ruselknow.Osicat.UnitTest.Handlers
{
    public class UninstallCommandHandlerShould
    {
        private readonly UninstallCommandHandler _commandHandler;

        public UninstallCommandHandlerShould()
        {
            _commandHandler = new UninstallCommandHandler();
        }

        [Fact]
        public void ThrowNotImplementException()
        {
            //act
            Func<Task<bool>> act = () => _commandHandler.Handle(new UninstallCommand(), CancellationToken.None);

            //assert
            act.Should().ThrowAsync<NotImplementedException>();
        }
    }
}