using SubscriptionTracker.Web.Client.Models;

namespace SubscriptionTracker.Web.Client.Observers
{
    public interface INotificationObserver
    {
        void Update(
            Subscription subscription,
            int daysRemaining
        );
    }
}