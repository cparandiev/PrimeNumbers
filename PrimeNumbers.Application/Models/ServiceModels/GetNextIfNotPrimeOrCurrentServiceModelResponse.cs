namespace PrimeNumbers.Application.Models.ServiceModels
{
    public class GetNextIfNotPrimeOrCurrentServiceModelResponse
    {
        public GetNextIfNotPrimeOrCurrentServiceModelResponse(int number)
        {
            Number = number;
        }

        public int Number { get;}
    }
}
