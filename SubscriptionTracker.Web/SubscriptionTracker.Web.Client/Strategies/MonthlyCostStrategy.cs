namespace SubscriptionTracker.Web.Client.Strategies
{
    public class MonthlyCostStrategy : ICostStrategy
    {
        public decimal CalculateMonthlyCost(decimal price)
        {
            return price;
        }

        public string GetBillingCycle()
        {
            return "Monthly";
        }
    }
}