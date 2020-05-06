using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PrimeNumbers.Application.Common.Interfaces;

namespace PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber
{
    public class CheckIsPrimeNumberQueryHandler : IRequestHandler<CheckIsPrimeNumberQuery, PrimeNumberDto>
    {
        private readonly IPrimeNumberChecker _primeNumberChecker;

        public CheckIsPrimeNumberQueryHandler(IPrimeNumberChecker primeNumberChecker)
        {
            _primeNumberChecker = primeNumberChecker;
        }
        public async Task<PrimeNumberDto> Handle(CheckIsPrimeNumberQuery request, CancellationToken cancellationToken)
        {
            var isPrimeNumber = await _primeNumberChecker.CheckAsync(request.Number.Value);
            var response = new PrimeNumberDto(request.Number.Value, isPrimeNumber);

            return response;
        }
    }
}
