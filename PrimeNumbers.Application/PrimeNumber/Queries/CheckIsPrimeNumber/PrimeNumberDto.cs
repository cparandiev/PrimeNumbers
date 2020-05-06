namespace PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber
{
    public class PrimeNumberDto
    {
        public PrimeNumberDto(int number, bool isPrime)
        {
            Number = number;
            IsPrime = isPrime;
        }

        public int Number { get; }

        public bool IsPrime { get; }
    }
}
