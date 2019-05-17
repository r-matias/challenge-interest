using FluentAssertions;
using System.Net; 
using System.Threading.Tasks;
using Xunit;

public class CalculationsTests
{
        private readonly TestContext _testContext;
        public CalculationsTests()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task InterestCalculate_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/Calculations/calculajuros?valorinicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task InterestCalculateValorInicial_ReturnsBadRequestResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/Calculations/calculajuros?valorinicial=xxx&meses=5");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task InterestCalculateMeses_ReturnsBadRequestResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/Calculations/calculajuros?valorinicial=100&meses=x");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }