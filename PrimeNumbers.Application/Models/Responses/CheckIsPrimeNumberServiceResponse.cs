namespace PrimeNumbers.Application.Models.Responses
{
    public class CheckIsPrimeNumberServiceResponse
    {
        public CheckIsPrimeNumberServiceResponse(int number, bool isPrime)
        {
            Number = number;
            IsPrime = isPrime;
        }

        public int Number { get; }

        public bool IsPrime { get; }
    }
}
