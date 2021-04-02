using MediatR;

namespace Ruselknow.Osicat.Commands
{
    public class AddCommand: IRequest<bool>
    {
        public string File { get; }

        public string Action { get; }

        public AddCommand(string file, string action)
        {
            File = file;
            Action = action;
        }
    }
}
