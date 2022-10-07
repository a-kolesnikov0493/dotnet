using System;

namespace Patterns.Behavioral.Command
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;

        public ComplexCommand(string a, string b, Receiver receiver)
        {
            _a = a;
            _b = b;
            _receiver = receiver;
        }
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }
}
