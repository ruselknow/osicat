using DocoptNet;
using MediatR;
using Ruselknow.Osicat.Commands;
using System;
using System.Collections.Generic;

namespace Ruselknow.Osicat
{
    public class CommandFactory: ICommandFactory
    {
        public IRequest<bool> Create(IDictionary<string, ValueObject> args)
        {
            if (args.TryGetValue("install", out var install) && install.IsTrue)
            {
                args.TryGetValue("<dir>", out var dir);
                return new InstallCommand(dir?.ToString());
            }

            if (args.TryGetValue("uninstall", out var uninstall) && uninstall.IsTrue)
            {
                return new UninstallCommand();
            }

            if (args.TryGetValue("add", out var add) && add.IsTrue)
            {
                //TODO add check
                args.TryGetValue("<file>", out var file);
                args.TryGetValue("<action>", out var action);

                return new AddCommand(file.ToString(), action.ToString());
            }

            if(args.TryGetValue("--version", out var version) && version.IsTrue)
            {
                return new VersionCommand();
            }

            throw new Exception("message");
        }
    }
}
