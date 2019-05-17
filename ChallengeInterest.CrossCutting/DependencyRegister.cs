using System;
using ChallengeInterest.Business;
using ChallengeInterest.Interfaces.IBusiness;
using Microsoft.Extensions.DependencyInjection;

namespace ChallengeInterest.CrossCutting
{
    public class DependencyRegister
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ICalculationsBusiness, CalculationsBusiness>();
            services.AddScoped<IInfoHubBusiness, InfoHubBusiness>();
        }
    }
}
