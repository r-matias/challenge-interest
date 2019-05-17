using ChallengeInterest.Interfaces.IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeInterest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        private readonly ICalculationsBusiness _calculationsBusiness;

        public CalculationsController(ICalculationsBusiness calculationsBusiness)
        {
            _calculationsBusiness = calculationsBusiness;
        }

        /// <summary>
        /// Realiza o calculo de juros baseado em um valor inicial (saldo) e a quantidade
        /// de meses que esse saldo vai render com 1% ao mês
        /// </summary>
        /// <param name="valorinicial">Saldo que sera calculado os juros</param>
        /// <param name="meses">Quantidade de meses que o saldo vai render</param>
        /// <returns>Retorna uma string no formato (pt-BR) 105,10</returns>
        [HttpGet]
        [Route("calculajuros")]
        public ActionResult<string> InterestCalculate(decimal valorinicial, int meses)
        {
            string resultCalculate = _calculationsBusiness.InterestCalculate(valorinicial, meses);
            
            return resultCalculate;
        }
    }
}
