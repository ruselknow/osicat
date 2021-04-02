using FluentAssertions;
using Ruselknow.Osicat.Commands;
using Ruselknow.Osicat.Handlers;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Ruselknow.Osicat.UnitTest.Handlers
{
    public class AddCommandHandlerShould
    {
        private readonly AddCommandHandler _commandHandler;

        public AddCommandHandlerShould()
        {
            _commandHandler = new AddCommandHandler();
        }

        [Fact]
        public void ThrowNotImplementException()
        {
            //act
            Func<Task<bool>> act = () => _commandHandler.Handle(new AddCommand("ds", "ds"), CancellationToken.None);

            //assert
            act.Should().ThrowAsync<NotImplementedException>();
        }
    }
}