using Patterns.Structural.Decorator.Notifiers;

namespace Patterns.Structural.Decorator.Notifier
{
    public class SmsNotifier : INotifier
    {
        public string Notify(string message)
        {
            return $"Sms: {message}";
        }
    }
}
