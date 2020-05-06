using MediatR;

namespace PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent
{
    public class GetNextIfNotPrimeOrCurrentQuery : IRequest<NextPrimeNumberVm>
    {
        public GetNextIfNotPrimeOrCurrentQuery(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
