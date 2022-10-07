namespace CommandPattern.Commands
{
    public interface ICommand
    {
        public ICommand Get();
        public void Execute();
    }
}