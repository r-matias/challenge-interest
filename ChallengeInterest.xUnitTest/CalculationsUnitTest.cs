using ChallengeInterest.Interfaces.IBusiness;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ChallengeInterest.xUnitTest
{
    public class CalculationsUnitTest : XUnitTestBase
    {
        private readonly ICalculationsBusiness _calculationsBusiness;

        public CalculationsUnitTest()
        {
            _calculationsBusiness = ServiceProvider.GetService<ICalculationsBusiness>();
        }

        [Fact]
        public void InterestCalculateTest()
        {
            string result = _calculationsBusiness.InterestCalculate(100, 5);

            Assert.Equal("105,10", result);
        }
    }
}
