using ChallengeInterest.Interfaces.IBusiness;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ChallengeInterest.xUnitTest
{
    public class InfoHubUnitTest : XUnitTestBase
    {
        private readonly IInfoHubBusiness _infoHubBusiness;

        public InfoHubUnitTest()
        {
            _infoHubBusiness = ServiceProvider.GetService<IInfoHubBusiness>();
        }

        [Fact]
        public void InterestCalculateTest()
        {
            string result = _infoHubBusiness.ShowMeTheCode();

            Assert.Equal("https://github.com/r-matias/challenge-interest.git", result);
        }
    }
}
