namespace PrimeNumbers.Application.Models.Requests
{
    public class CheckIsPrimeNumberServiceRequest
    {
        public CheckIsPrimeNumberServiceRequest(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
