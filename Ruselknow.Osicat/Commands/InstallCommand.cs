using MediatR;

namespace Ruselknow.Osicat.Commands
{
    public class InstallCommand: IRequest<bool>
    {
        private const string defaultDirectory = ".osicat";

        public string Directory { get; } 

        public InstallCommand(string dir)
        {
            Directory = string.IsNullOrEmpty(dir) || string.IsNullOrWhiteSpace(dir) 
                ? defaultDirectory 
                : dir;
        }
    }
}
