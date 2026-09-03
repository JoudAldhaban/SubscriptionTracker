namespace SubscriptionTracker.Web.Client.Strategies
{
    public class YearlyCostStrategy : ICostStrategy
    {
        public decimal CalculateMonthlyCost(decimal price)
        {
            return price / 12;
        }

        public string GetBillingCycle()
        {
            return "Yearly";
        }
    }
}