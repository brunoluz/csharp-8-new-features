using System;
namespace csharp_8_new_features
{
    public interface ICustomer
    {
        public DateTime CreatedAt { get; set; }

        // The most common scenario is to safely add members to an interface already released and used by innumerable clients.
        public decimal ComputeLoyaltyDiscount()
        {
            var twoYearsAgo = DateTime.Now.AddYears(-2);

            return CreatedAt < twoYearsAgo ? 0.10m : 0;
        }
    }
}
