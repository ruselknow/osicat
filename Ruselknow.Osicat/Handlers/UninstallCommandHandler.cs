using MediatR;
using Ruselknow.Osicat.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ruselknow.Osicat.Handlers
{
    public class UninstallCommandHandler: IRequestHandler<UninstallCommand, bool>
    {
        public Task<bool> Handle(UninstallCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}