using System;
using NUnit.Framework;
using ShapesDemo;

namespace ShapesDemoTest
{
    [TestFixture]
    public class UnitTest1
    {

        // testing side input
        [Test]
        [TestCase(5, 5)]
        [TestCase(10, 10)]
        [TestCase(3, 3)]
        public void Constructor_IsCalled_PropertiesSet(int pInput, int pExpected)
        {
            // Arrange
            var sq = new Square(pInput);
            // Act

            // Assert

            Assert.That(sq.SideLength.Equals(pExpected));
        }

        [Test]
        [TestCase(5, 25)]
        [TestCase(10, 100)]
        [TestCase(3, 9)]
        
        //testing area valid inputs
        public void GetArea_ValidInputs(int pInput, int pExpected)
        {
            // Arrange
            var sq = new Square(pInput);
            // Act

            // Assert

            Assert.That(sq.GetArea().Equals(pExpected));
        }
        [Test]
        [TestCase(5, 20)]
        [TestCase(10, 40)]
        [TestCase(3, 12)]

        //testing perimeter valid inputs
        public void GetPerimeter_ValidInputs(int pInput, int pExpected)
        {
            // Arrange
            var sq = new Square(pInput);
            // Act

            // Assert

            Assert.That(sq.GetPerimeter().Equals(pExpected));
        }

    }
}
