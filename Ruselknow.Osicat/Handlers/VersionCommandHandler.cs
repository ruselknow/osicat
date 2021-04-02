using MediatR;
using Ruselknow.Osicat.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace Ruselknow.Osicat.Handlers
{
    public class VersionCommandHandler: IRequestHandler<VersionCommand, bool>
    {
        public Task<bool> Handle(VersionCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Console.WriteLine(GetVersion());
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }

        private static string GetVersion()
        {
            return Assembly.GetEntryAssembly()!
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
        }
    }
}