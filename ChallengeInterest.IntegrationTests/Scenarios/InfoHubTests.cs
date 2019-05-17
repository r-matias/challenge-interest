using FluentAssertions;
using System.Net; 
using System.Threading.Tasks;
using Xunit;

public class InfoHubTests
{
        private readonly TestContext _testContext;
        public InfoHubTests()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task InterestCalculate_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/InfoHub/showmethecode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }