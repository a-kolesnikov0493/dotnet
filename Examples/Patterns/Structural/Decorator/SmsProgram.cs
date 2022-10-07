using Patterns.Structural.Decorator.Notifiers;

namespace Patterns.Structural.Decorator
{
    public class SmsProgram : Program
    {
        public SmsProgram(INotifier notifier) : base(notifier)
        {
        }

        public override string Notify(string message)
        {
            return base.Notify(message) + "Some additional functionality for sms";
        }
    }
}
