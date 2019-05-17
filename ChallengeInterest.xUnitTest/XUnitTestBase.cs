using ChallengeInterest.CrossCutting;
using Microsoft.Extensions.DependencyInjection;

namespace ChallengeInterest.xUnitTest
{
    public abstract class XUnitTestBase
    {
        private static ServiceCollection _serviceCollection;

        public XUnitTestBase()
        {
            _serviceCollection = new ServiceCollection();
            DependencyRegister.Register(_serviceCollection);
            ServiceProvider = _serviceCollection.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}
