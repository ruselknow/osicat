using FluentAssertions;
using Ruselknow.Osicat.Commands;
using Xunit;

namespace Ruselknow.Osicat.UnitTest.Commands
{
    public class InstallCommandShould
    {
        private const string defaultDirectory = ".osicat";

        [Fact]
        public void SetDefaultDirectory_WhenNullPassed()
        {
            //act
            var command = new InstallCommand(null);

            //assert
            command.Should().NotBeNull();
            command.Directory.Should().NotBeNull();
            command.Directory.Should().Be(defaultDirectory);
        }

        [Fact]
        public void SetDefaultDirectory_WhenEmptyStringPassed()
        {
            //act
            var command = new InstallCommand(string.Empty);

            //assert
            command.Should().NotBeNull();
            command.Directory.Should().NotBeNull();
            command.Directory.Should().Be(defaultDirectory);
        }

        [Fact]
        public void SetDefaultDirectory_WhenWhiteSpacePassed()
        {
            //act
            var command = new InstallCommand("     ");

            //assert
            command.Should().NotBeNull();
            command.Directory.Should().NotBeNull();
            command.Directory.Should().Be(defaultDirectory);
        }

        [Fact]
        public void SetPassedDirectory()
        {
            //arrange
            var dir = "hook dir";

            //act
            var command = new InstallCommand(dir);

            //assert
            command.Should().NotBeNull();
            command.Directory.Should().NotBeNull();
            command.Directory.Should().Be(dir);
        }
    }
}