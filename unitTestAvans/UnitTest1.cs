using FluentAssertions;
using ShippingCostsCalculator;

namespace unitTestAvans
{
    public class UnitTest1
    {

        ClassAssignmentAvans _classAssignmentAvans = new ClassAssignmentAvans();

        [Fact]
        public void WhenCalculateShippingCostsIsFalse_ReturnsZero()
        {
            // Arrange
            bool calculateShippingCosts = false;
            string typeOfShippingCosts = "Ground";
            double totalPrice = 1000;

            // Act2222
            double result = _classAssignmentAvans.ShippingCosts(calculateShippingCosts, typeOfShippingCosts, totalPrice);

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void WhenCalculateShippingCostsIsTrueAndTotalPriceIsGreaterThan1500_ReturnsZero()
        {
            // Arrange
            bool calculateShippingCosts = true;
            string typeOfShippingCosts = "Ground";
            double totalPrice = 2000;

            // Act
            double result = _classAssignmentAvans.ShippingCosts(calculateShippingCosts, typeOfShippingCosts, totalPrice);

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void WhenCalculateShippingCostsIsTrueAndTotalPriceIsLessThanOrEqualTo1500AndTypeOfShippingCostsIsGround_Returns100()
        {
            // Arrange
            bool calculateShippingCosts = true;
            string typeOfShippingCosts = "Ground";
            double totalPrice = 1000;

            // Act
            double result = _classAssignmentAvans.ShippingCosts(calculateShippingCosts, typeOfShippingCosts, totalPrice);

            // Assert
            result.Should().Be(100);
        }

        [Fact]
        public void WhenCalculateShippingCostsIsTrueAndTotalPriceIsLessThanOrEqualTo1500AndTypeOfShippingCostsIsInStore_Returns50()
        {
            // Arrange
            bool calculateShippingCosts = true;
            string typeOfShippingCosts = "InStore";
            double totalPrice = 1000;

            // Act
            double result = _classAssignmentAvans.ShippingCosts(calculateShippingCosts, typeOfShippingCosts, totalPrice);

            // Assert
            result.Should().Be(50);
        }

        [Fact]
        public void WhenCalculateShippingCostsIsTrueAndTotalPriceIsLessThanOrEqualTo1500AndTypeOfShippingCostsIsNextDayAir_Returns250()
        {
            // Arrange
            bool calculateShippingCosts = true;
            string typeOfShippingCosts = "NextDayAir";
            double totalPrice = 1000;

            // Act
            double result = _classAssignmentAvans.ShippingCosts(calculateShippingCosts, typeOfShippingCosts, totalPrice);

            // Assert
            result.Should().Be(250);
        }

        [Fact]
        public void WhenCalculateShippingCostsIsTrueAndTotalPriceIsLessThanOrEqualTo1500AndTypeOfShippingCostsIsSecondDayAir_Returns125()
        {
            // Arrange
            bool calculateShippingCosts = true;
            string typeOfShippingCosts = "SecondDayAir";
            double totalPrice = 1000;

            // Act
            double result = _classAssignmentAvans.ShippingCosts(calculateShippingCosts, typeOfShippingCosts, totalPrice);

            // Assert
            result.Should().Be(125);
        }

    }   
}