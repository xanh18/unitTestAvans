using FluentAssertions;

namespace unitTestAvans
{
    public class UnitTest1
    {
        [Fact]
        public void calculateShippingCostsIsFalse()
        {
            // Customer Object with null Id property
            var shippingCosts = ShippingCosts(false, "ground", 50);
            // Asserts that calling GetId() will throw

            shippingCosts.Should().Be(0);
        }


     
        public double ShippingCosts(bool calculateShippingCosts, string typeOfShippingCosts, double totalPrice)
        {
            double result = 0;
            if (calculateShippingCosts == true)
            {
                if (totalPrice > 1500)
                {
                    result = 0;
                }
                else
                {
                    switch (typeOfShippingCosts)
                    {
                        case "Ground":
                            result = 100;
                            break;
                        case "InStore":
                            result = 50;
                            break;
                        case "NextDayAir":
                            result = 250;
                            break;
                        case "SecondDayAir":
                            result = 125;
                            break;
                        default:
                            result = 0;
                            break;
                    }
                }
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
    
}