using DocoptNet;
using FluentAssertions;
using MediatR;
using Ruselknow.Osicat.Commands;
using System;
using System.Collections.Generic;
using Xunit;


namespace Ruselknow.Osicat.UnitTest
{
    public class CommandFactoryShould
    {
        private readonly ICommandFactory _factory;

        public CommandFactoryShould()
        {
            _factory = new CommandFactory();
        }

        [Fact]
        public void CreateInstallCommand()
        {
            //arrange
            var args = new Dictionary<string, ValueObject>(0)
            {
                {
                    "install", 
                    CreateValueObject(true)
                }
            };

            //act
            var command = _factory.Create(args);

            command.Should().NotBeNull();
            command.Should().BeOfType<InstallCommand>();
        }

        [Fact]
        public void CreateUninstallCommand()
        {
            //arrange
            var args = new Dictionary<string, ValueObject>(0)
            {
                {
                    "uninstall", 
                    CreateValueObject(true)
                }
            };

            //act
            var command = _factory.Create(args);

            command.Should().NotBeNull();
            command.Should().BeOfType<UninstallCommand>();
        }

        [Fact]
        public void CreateAddCommand()
        {
            //arrange
            var args = new Dictionary<string, ValueObject>(3)
            {
                {
                    "add", 
                    CreateValueObject(true)
                },
                {
                    "<file>",
                    CreateValueObject("file")
                },
                {
                    "<action>",
                    CreateValueObject("action")
                }
            };

            //act
            var command = _factory.Create(args);

            command.Should().NotBeNull();
            command.Should().BeOfType<AddCommand>();
        }

        [Fact]
        public void CreateVersionCommand()
        {
            //arrange
            var args = new Dictionary<string, ValueObject>(1)
            {
                {
                    "--version", 
                    CreateValueObject(true)
                }
            };

            //act
            var command = _factory.Create(args);

            command.Should().NotBeNull();
            command.Should().BeOfType<VersionCommand>();
        }    

        [Fact]
        public void ThrowsException()
        {
            //arrange
            var args = new Dictionary<string, ValueObject>(0);

            //act
            Func<IRequest<bool>> act = () => _factory.Create(args);

            //assert
            act.Should().Throw<Exception>();
        }  

        private static ValueObject CreateValueObject(object value)
        {
            return (ValueObject)Activator.CreateInstance(typeof(ValueObject),
                System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance,
                null, new object[] {value}, null);
        }
    }
}