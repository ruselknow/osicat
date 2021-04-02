using MediatR;
using Ruselknow.Osicat.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ruselknow.Osicat.Handlers
{
    public class InstallCommandHandler: IRequestHandler<InstallCommand, bool>
    {
        public Task<bool> Handle(InstallCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}