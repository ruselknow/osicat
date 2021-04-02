using MediatR;
using Ruselknow.Osicat.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ruselknow.Osicat.Handlers
{
    public class VersionCommandHandler: IRequestHandler<VersionCommand, bool>
    {
        public Task<bool> Handle(VersionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}