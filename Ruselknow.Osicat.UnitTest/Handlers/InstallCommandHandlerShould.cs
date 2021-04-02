using FluentAssertions;
using Ruselknow.Osicat.Commands;
using Ruselknow.Osicat.Handlers;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Ruselknow.Osicat.UnitTest.Handlers
{
    public class InstallCommandHandlerShould
    {
        private readonly InstallCommandHandler _commandHandler;

        public InstallCommandHandlerShould()
        {
            _commandHandler = new InstallCommandHandler();
        }

        [Fact]
        public void ThrowNotImplementException()
        {
            //act
            Func<Task<bool>> act = () => _commandHandler.Handle(new InstallCommand(), CancellationToken.None);

            //assert
            act.Should().ThrowAsync<NotImplementedException>();
        }
    }
}