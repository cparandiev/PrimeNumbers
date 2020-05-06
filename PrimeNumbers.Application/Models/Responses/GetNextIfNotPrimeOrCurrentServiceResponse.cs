namespace PrimeNumbers.Application.Models.Responses
{
    public class GetNextIfNotPrimeOrCurrentServiceResponse
    {
        public GetNextIfNotPrimeOrCurrentServiceResponse(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
