using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PrimeNumbers.Application.Common.Interfaces;

namespace PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber
{
    public class CheckIsPrimeNumberQueryHandler : IRequestHandler<CheckIsPrimeNumberQuery, PrimeNumberVm>
    {
        private readonly IPrimeNumberChecker _primeNumberChecker;

        public CheckIsPrimeNumberQueryHandler(IPrimeNumberChecker primeNumberChecker)
        {
            _primeNumberChecker = primeNumberChecker;
        }
        public async Task<PrimeNumberVm> Handle(CheckIsPrimeNumberQuery request, CancellationToken cancellationToken)
        {
            var isPrimeNumber = await _primeNumberChecker.CheckAsync(request.Number);
            var response = new PrimeNumberVm(request.Number, isPrimeNumber);

            return response;
        }
    }
}
