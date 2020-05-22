using NUnit.Framework;

namespace csharp_8_new_features.Tests
{
    public class RectangleTests
    {
        [Test]
        public void Rectangle_Area_Test()
        {
            var sut = new Rectangle() { X = 2, Y = 3 };

            Assert.AreEqual(6, sut.Area);
        }

        [Test]
        public void Rectangle_ToString_Test()
        {
            var sut = new Rectangle() { X = 2, Y = 3 };

            Assert.AreEqual("Rectangle area is 6", sut.ToString());
        }
    }
}