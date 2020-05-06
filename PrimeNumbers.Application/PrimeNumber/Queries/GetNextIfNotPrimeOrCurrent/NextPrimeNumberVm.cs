namespace PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent
{
    public class NextPrimeNumberVm
    {
        public NextPrimeNumberVm(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
