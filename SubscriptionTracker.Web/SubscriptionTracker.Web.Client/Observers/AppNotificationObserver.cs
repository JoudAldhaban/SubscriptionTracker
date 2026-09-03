using SubscriptionTracker.Web.Client.Models;

namespace SubscriptionTracker.Web.Client.Observers
{
    public class AppNotificationObserver
        : INotificationObserver
    {
        public List<string> Messages { get; private set; }
            = new List<string>();

        public void Update(
            Subscription subscription,
            int daysRemaining)
        {
            string message;

            if (daysRemaining == 0)
            {
                message =
                    subscription.Name +
                    " renews today!";
            }
            else
            {
                message =
                    subscription.Name +
                    " will renew in " +
                    daysRemaining +
                    " day(s).";
            }

            Messages.Add(message);
        }

        public void ClearMessages()
        {
            Messages.Clear();
        }
    }
}