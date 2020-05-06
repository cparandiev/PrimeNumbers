namespace PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent
{
    public class NextPrimeNumberDto
    {
        public NextPrimeNumberDto(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
