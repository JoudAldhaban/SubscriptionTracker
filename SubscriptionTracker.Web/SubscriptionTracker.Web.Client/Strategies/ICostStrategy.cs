namespace SubscriptionTracker.Web.Client.Strategies
{
    public interface ICostStrategy
    {
        public abstract decimal CalculateMonthlyCost(decimal price);

        public abstract string GetBillingCycle();
    }
}