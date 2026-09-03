using SubscriptionTracker.Web.Client.Models;

namespace SubscriptionTracker.Web.Client.Services
{
    public class SubscriptionService
    {
        private readonly List<Subscription> subscriptions
            = new List<Subscription>();

        public List<Subscription> GetSubscriptions()
        {
            return subscriptions;
        }

        public void AddSubscription(
            Subscription subscription)
        {
            subscriptions.Add(subscription);
        }

        public void DeleteSubscription(
            Subscription subscription)
        {
            subscriptions.Remove(subscription);
        }

        public decimal GetAverageMonthlyCost()
        {
            decimal total = 0;

            foreach (Subscription subscription in subscriptions)
            {
                total += subscription.GetMonthlyCost();
            }

            return total;
        }

        public Subscription? GetNextRenewal()
        {
            return subscriptions
                .OrderBy(subscription =>
                    subscription.RenewalDate)
                .FirstOrDefault();
        }
    }
}