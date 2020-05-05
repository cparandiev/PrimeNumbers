namespace PrimeNumbers.Application.Models.ServiceModels
{
    public class CheckIsPrimeNumberServiceModelRequest
    {
        public CheckIsPrimeNumberServiceModelRequest(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
