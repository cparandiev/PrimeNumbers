namespace PrimeNumbers.Application.Models.ServiceModels
{
    public class CheckIsPrimeNumberServiceModelResponse
    {
        public CheckIsPrimeNumberServiceModelResponse(int number, bool isPrime)
        {
            Number = number;
            IsPrime = isPrime;
        }

        public int Number { get; }

        public bool IsPrime { get; }
    }
}
