namespace PrimeNumbers.Application.Models.ServiceModels
{
    public class GetNextIfNotPrimeOrCurrentServiceModelRequest
    {
        public GetNextIfNotPrimeOrCurrentServiceModelRequest(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
