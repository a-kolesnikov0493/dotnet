using System;

namespace Patterns.Behavioral.Command
{
    public class Invoker
    {
        private readonly ICommand _onStart;
        private readonly ICommand _onFinish;

        public Invoker(ICommand onStart, ICommand onFinish)
        {
            _onStart = onStart;
            _onFinish = onFinish;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
}
