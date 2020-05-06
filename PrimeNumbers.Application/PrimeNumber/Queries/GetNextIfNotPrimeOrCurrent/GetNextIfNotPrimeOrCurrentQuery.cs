using MediatR;

namespace PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent
{
    public class GetNextIfNotPrimeOrCurrentQuery : IRequest<NextPrimeNumberDto>
    {
        public GetNextIfNotPrimeOrCurrentQuery(int? number)
        {
            Number = number;
        }

        public int? Number { get; }
    }
}
