namespace PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber
{
    public class PrimeNumberVm
    {
        public PrimeNumberVm(int number, bool isPrime)
        {
            Number = number;
            IsPrime = isPrime;
        }

        public int Number { get; }

        public bool IsPrime { get; }
    }
}
