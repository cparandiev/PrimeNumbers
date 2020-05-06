using MediatR;
using PrimeNumbers.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent
{
    public class GetNextIfNotPrimeOrCurrentQueryHandler : IRequestHandler<GetNextIfNotPrimeOrCurrentQuery, NextPrimeNumberVm>
    {
        private readonly IPrimeNumberGenerator _primeNumberGenerator;
        private readonly IPrimeNumberChecker _primeNumberChecker;


        public GetNextIfNotPrimeOrCurrentQueryHandler(IPrimeNumberGenerator primeNumberGenerator, IPrimeNumberChecker primeNumberChecker)
        {
            _primeNumberGenerator = primeNumberGenerator;
            _primeNumberChecker = primeNumberChecker;
        }

        public async Task<NextPrimeNumberVm> Handle(GetNextIfNotPrimeOrCurrentQuery request, CancellationToken cancellationToken)
        {
            var isPrimeNumber = await _primeNumberChecker.CheckAsync(request.Number.Value);

            var nextPrimeNumber = request.Number.Value;

            if (!isPrimeNumber)
            {
                nextPrimeNumber = await _primeNumberGenerator.GetNextPrimeNumberAsync(request.Number.Value);
            }

            var response = new NextPrimeNumberVm(nextPrimeNumber);

            return response;
        }
    }
}
