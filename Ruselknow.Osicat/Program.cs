using DocoptNet;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Ruselknow.Osicat
{
    class Program
    {        
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICommandFactory, CommandFactory>()
                .AddMediatR(Assembly.GetExecutingAssembly())
                .BuildServiceProvider();

            var commandFactory = serviceProvider.GetService<ICommandFactory>();
            var mediator = serviceProvider.GetService<IMediator>();
            
            var arguments = new Docopt()
                .Apply(DocoptConfig.Usage, args, exit: true);

            var command = commandFactory.Create(arguments);
            mediator.Send(command);
        }
    }
}
