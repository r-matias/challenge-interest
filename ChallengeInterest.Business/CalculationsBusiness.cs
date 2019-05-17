using System;
using System.Globalization;
using ChallengeInterest.Interfaces.IBusiness;
using ChallengeInterest.ViewModel;

namespace ChallengeInterest.Business
{
    public class CalculationsBusiness : ICalculationsBusiness
    {
        public string InterestCalculate(decimal initialValue, int time)
        {
            InterestCalculateViewModel model = new InterestCalculateViewModel(initialValue, time);

            model.Validate();

            decimal powerResult = (decimal)Math.Pow((1 + 0.01), model.Time);

            decimal multiplicateResult = model.InitialValue * powerResult;

            decimal result = decimal.Round(multiplicateResult, 2);

            return result.ToString(new CultureInfo("pt-BR"));
        }
    }
}
