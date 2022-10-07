using CommandPattern.Commands;

namespace CommandPattern.Service
{
    public interface ICommandService<T> where T : ICommand
    {
        public T Execute(ICommand command);
    }
}
