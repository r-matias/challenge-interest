using ChallengeInterest.Interfaces.IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeInterest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoHubController : ControllerBase
    {
        private readonly IInfoHubBusiness _infoHubBusiness;

        public InfoHubController(IInfoHubBusiness infoHubBusiness)
        {
            _infoHubBusiness = infoHubBusiness;
        }

        /// <summary>
        /// Retorna a url do código do desse projeto no GitHub
        /// </summary>
        /// <returns>Retorna uma string com a url do código no GitHub</returns>
        [HttpGet]
        [Route("showmethecode")]
        public ActionResult<string> ShowMeTheCode()
        {
            string resultHub = _infoHubBusiness.ShowMeTheCode();

            return resultHub;
        }
    }
}
