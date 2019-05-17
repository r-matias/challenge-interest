using ChallengeInterest.Interfaces.IBusiness;

namespace ChallengeInterest.Business
{
    public class InfoHubBusiness : IInfoHubBusiness
    {
        public string ShowMeTheCode()
        {
            return "https://github.com/r-matias/challenge-interest.git";
        }
    }
}