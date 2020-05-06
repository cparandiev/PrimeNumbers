using MediatR;

namespace PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber
{
    public class CheckIsPrimeNumberQuery : IRequest<PrimeNumberVm>
    {
        public CheckIsPrimeNumberQuery(int? number)
        {
            Number = number;
        }

        public int? Number { get; }
    }
}
