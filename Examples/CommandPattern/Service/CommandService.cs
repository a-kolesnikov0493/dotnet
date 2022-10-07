using CommandPattern.Commands;

namespace CommandPattern.Service
{
    public class CommandService<T> : ICommandService<T> where T : ICommand
    {
        public T Execute(ICommand command)
        {
            return (T)command.Get();
        }
    }
}
