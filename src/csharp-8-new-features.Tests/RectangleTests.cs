using NUnit.Framework;

namespace csharp_8_new_features.Tests
{
    public class RectangleTests
    {
        [Test]
        public void Square_Area_Test()
        {
            var sut = new Rectangle() { X = 2, Y = 3 };

            Assert.AreEqual(6, sut.Area);
        }
    }
}