using System;

namespace CommandPattern.Commands
{
    public class CheckInCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Executing Check-In Command");
        }

        public ICommand Get()
        {
            return new CheckInCommand();
        }
    }
}
