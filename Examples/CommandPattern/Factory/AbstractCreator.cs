using CommandPattern.Commands;

namespace CommandPattern.Factory
{
    public abstract class AbstractCreator
    {
        public abstract ICommand FactoryMethod(int command);

        public void Execute(int command)
        {
            var comm = FactoryMethod(command);
            comm.Execute();
        }
    }
}
