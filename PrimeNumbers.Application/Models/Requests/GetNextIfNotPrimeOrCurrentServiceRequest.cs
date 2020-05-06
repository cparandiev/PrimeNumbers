namespace PrimeNumbers.Application.Models.Requests
{
    public class GetNextIfNotPrimeOrCurrentServiceRequest
    {
        public GetNextIfNotPrimeOrCurrentServiceRequest(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
