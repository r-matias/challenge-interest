using System;

namespace ChallengeInterest.ViewModel
{
    public class InterestCalculateViewModel
    {
        public InterestCalculateViewModel(decimal initialValue, int time)
        {
            InitialValue = initialValue;
            Time = time;
        }

        public decimal InitialValue { get; private set; }
        public int Time { get; private set; }
        public bool IsValid { get; private set; } = false;

        public void Validate()
        {
            try
            {
                if (InitialValue <= 0)
                    throw new ArgumentException($"Property {nameof(InitialValue)} has invalid value.");

                if (Time <= 0)
                    throw new ArgumentException($"Property {nameof(Time)} has invalid value.");

                IsValid = true;
            }
            catch (Exception)
            {
                IsValid = false;
                throw;
            }
        }
    }
}
