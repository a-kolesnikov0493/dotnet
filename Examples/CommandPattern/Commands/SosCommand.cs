using System;

namespace CommandPattern.Commands
{
    public class SosCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Executing Sos Command");
        }

        public ICommand Get()
        {
            return new SosCommand();
        }
    }
}
