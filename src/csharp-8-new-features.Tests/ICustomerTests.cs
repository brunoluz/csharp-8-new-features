using System;
using Moq;
using NUnit.Framework;

namespace csharp_8_new_features.Tests
{
    public class ICustomerTests
    {
        class CustomerImplementation : ICustomer
        {
            public DateTime CreatedAt { get; set; }
        }

        [Test]
        public void ICustomer_ComputeLoyaltyDiscount_DiscountApplied_Test()
        {
            ICustomer sut = new CustomerImplementation();
            sut.CreatedAt = DateTime.Now.AddYears(-3);

            decimal discount = sut.ComputeLoyaltyDiscount();

            Assert.AreEqual(0.10m, discount);
        }

        [Test]
        public void ICustomer_ComputeLoyaltyDiscount_DiscountNotApplied_Test()
        {
            ICustomer sut = new CustomerImplementation();
            sut.CreatedAt = DateTime.Now;

            decimal discount = sut.ComputeLoyaltyDiscount();

            Assert.AreEqual(0, discount);
        }
    }
}
