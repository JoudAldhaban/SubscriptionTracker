using SubscriptionTracker.Web.Client.Strategies;

namespace SubscriptionTracker.Web.Client.Models
{
    public class Subscription
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; } 
        public DateTime StartDate { get; private set; }

        public DateTime RenewalDate { get; private set; }

        private readonly ICostStrategy costStrategy;

        public Subscription(
            string name,
            decimal price,
            DateTime startDate,
            ICostStrategy costStrategy)
        {
            Name = name;
            Price = price;
            StartDate = startDate.Date;

            this.costStrategy = costStrategy;

            RenewalDate = CalculateNextRenewalDate();
        }

        public decimal GetMonthlyCost()
        {
            return costStrategy.CalculateMonthlyCost(Price);
        }

        public string GetBillingCycle()
        {
            return costStrategy.GetBillingCycle();
        }

        private DateTime CalculateNextRenewalDate()
        {
            DateTime nextRenewal = StartDate;

            do
            {
                if (GetBillingCycle() == "Monthly")
                {
                    nextRenewal = nextRenewal.AddMonths(1);
                }
                else
                {
                    nextRenewal = nextRenewal.AddYears(1);
                }

            } while (nextRenewal.Date <= DateTime.Today);

            return nextRenewal;
        }
    }
}