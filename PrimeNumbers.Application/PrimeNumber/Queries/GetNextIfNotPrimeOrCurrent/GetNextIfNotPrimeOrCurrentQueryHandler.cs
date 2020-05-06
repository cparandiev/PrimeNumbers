using FluentValidation;
using FluentValidation.Results;
using MediatR;
using PrimeNumbers.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ValidationException = PrimeNumbers.Application.Common.Exceptions.ValidationException;

namespace PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent
{
    public class GetNextIfNotPrimeOrCurrentQueryHandler : IRequestHandler<GetNextIfNotPrimeOrCurrentQuery, NextPrimeNumberDto>
    {
        private readonly IPrimeNumberGenerator _primeNumberGenerator;
        private readonly IPrimeNumberChecker _primeNumberChecker;


        public GetNextIfNotPrimeOrCurrentQueryHandler(IPrimeNumberGenerator primeNumberGenerator, IPrimeNumberChecker primeNumberChecker)
        {
            _primeNumberGenerator = primeNumberGenerator;
            _primeNumberChecker = primeNumberChecker;
        }

        public async Task<NextPrimeNumberDto> Handle(GetNextIfNotPrimeOrCurrentQuery request, CancellationToken cancellationToken)
        {
            var isPrimeNumber = await _primeNumberChecker.CheckAsync(request.Number.Value);

            var nextPrimeNumber = request.Number.Value;

            if (!isPrimeNumber)
            {
                try
                {
                    nextPrimeNumber = await _primeNumberGenerator.GetNextPrimeNumberAsync(request.Number.Value);
                }
                catch (ArgumentOutOfRangeException)
                {
                    var validationFailure = new ValidationFailure(nameof(request.Number), "The number is too big and it's currently not supported.");
                    throw new ValidationException(new List<ValidationFailure>() { validationFailure });
                }
            }

            var response = new NextPrimeNumberDto(nextPrimeNumber);

            return response;
        }
    }
}
