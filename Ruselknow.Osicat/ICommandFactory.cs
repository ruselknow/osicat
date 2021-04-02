using DocoptNet;
using MediatR;
using System.Collections.Generic;

namespace Ruselknow.Osicat
{
    public interface ICommandFactory
    {
        IRequest<bool> Create(IDictionary<string, ValueObject> args);
    } 
}
