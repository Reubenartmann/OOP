using System;
using NUnit;
using NUnit.Framework;
using Challenge02;

namespace Challenge02Tests
{
    [TestFixture]
    public class UnitTest1
    {

        // SQUARE EXPECTED AREA
        [Test]
        [TestCase(5, 25)]
        [TestCase(15, 225)]
        [TestCase(7, 49)]
        public void SquareExpectedArea(double pInput, double pExpected)
        {
            // Arrange
            var sq = new Square(0, pInput, pInput, pInput, pInput);

            // Act

            // Assert

            Assert.That(sq.GetArea().Equals(pExpected));

        }

        // SQUARE EXPECTED PERIMETER
        [Test]
        [TestCase(5, 20)]
        [TestCase(15, 60)]
        [TestCase(7, 28)]
        public void SquareExpectedPerimeter(double pInput, double pExpected)
        {
            // Arrange
            var sq = new Square(0, pInput, pInput, pInput, pInput);

            // Act

            // Assert

            Assert.That(sq.GetPerimeter().Equals(pExpected));
        }


        // RECTANGLE EXPECTED AREA
        [Test]
        [TestCase(5, 10, 50)]
        [TestCase(4, 6, 24)]
        [TestCase(9, 7, 63)]
        public void RectangleExpectedArea(double Side1, double Side2, double pExpected)
        {
            // Arrange
            var re = new Rectangle(0, Side1, Side2, Side1, Side2);

            // Act

            // Assert

            Assert.That(re.GetArea().Equals(pExpected));

        }

        // RECTANGLE EXPECTED PERIMETER
        [Test]
        [TestCase(5, 10, 30)]
        [TestCase(4, 6, 20)]
        [TestCase(9, 7, 32)]
        public void RectangleExpectedPerimeter(double Side1, double Side2, double pExpected)
        {
            // Arrange
            var re = new Rectangle(0, Side1, Side2, Side1, Side2);

            // Act

            // Assert

            Assert.That(re.GetPerimeter().Equals(pExpected));
        }


        // EQUILATERAL EXPECTED AREA
        [Test]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void EquilateralExpectedArea(double Side1, double pExpected)
        {
            // Arrange

            // Act

            // Assert

        }
        // EQUILATERAL EXPECTED PERIMETER
        [Test]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void EquilateralExpectedPerimeter(double Side1, double pExpected)
        {
            // Arrange

            // Act

            // Assert
        }
        // RIGHT-ANGLE EXPECTED AREA
        [Test]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void RightAngleExpectedArea(double Side1, double Side2, double pExpected)
        {
            // Arrange

            // Act

            // Assert
        }
        // RIGHT-ANGLE EXPECTED PERMETER
        [Test]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void RightAngleExpectedPerimeter(double Side1, double Side2, double pExpected)
        {
            // Arrange

            // Act

            // Assert
        }
        // CIRCLE EXPECTED AREA
        [Test]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void CircleExpectedArea(double Side1, double pExpected)
        {
            // Arrange

            // Act

            // Assert
        }
        // CIRCLE EXPECTED PERMETER
        [Test]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void CircleExpectedPerimeter(double Side1, double pExpected)
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
