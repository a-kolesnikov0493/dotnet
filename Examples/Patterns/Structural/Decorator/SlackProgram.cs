using Patterns.Structural.Decorator.Notifiers;

namespace Patterns.Structural.Decorator
{
    public class SlackProgram : Program
    {
        public SlackProgram(INotifier notifier) : base(notifier)
        {
        }

        public override string Notify(string message)
        {
            return base.Notify(message) + "Some additional functionality for slack";
        }
    }
}
