using SubscriptionTracker.Web.Client.Models;

namespace SubscriptionTracker.Web.Client.Observers
{
    public class RenewalNotifier
    {
        private readonly List<INotificationObserver> observers
            = new List<INotificationObserver>();

        public void AddObserver(
            INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public int CheckRenewals(
            List<Subscription> subscriptions)
        {
            int notificationCount = 0;

            foreach (Subscription subscription in subscriptions)
            {
                int daysRemaining =
                    (subscription.RenewalDate.Date -
                     DateTime.Today).Days;

                if (daysRemaining >= 0 &&
                    daysRemaining <= 3)
                {
                    NotifyObservers(
                        subscription,
                        daysRemaining
                    );

                    notificationCount++;
                }
            }

            return notificationCount;
        }

        private void NotifyObservers(
            Subscription subscription,
            int daysRemaining)
        {
            foreach (INotificationObserver observer in observers)
            {
                observer.Update(
                    subscription,
                    daysRemaining
                );
            }
        }
    }
}