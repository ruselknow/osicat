using MediatR;
using Ruselknow.Osicat.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ruselknow.Osicat.Handlers
{
    public class AddCommandHandler: IRequestHandler<AddCommand, bool>
    {
        public Task<bool> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}