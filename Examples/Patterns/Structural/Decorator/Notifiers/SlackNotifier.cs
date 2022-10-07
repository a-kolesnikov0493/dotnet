using Patterns.Structural.Decorator.Notifiers;

namespace Patterns.Structural.Decorator.Notifier
{
    public class SlackNotifier : INotifier
    {
        public string Notify(string message)
        {
            return $"Slack: {message}";
        }
    }
}
