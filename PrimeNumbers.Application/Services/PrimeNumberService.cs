using PrimeNumbers.Application.Interfaces;
using PrimeNumbers.Application.Models.ServiceModels;
using System.Threading.Tasks;

namespace PrimeNumbers.Application.Services
{
    public class PrimeNumberService : IPrimeNumberService
    {
        private readonly IPrimeNumberGenerator _primeNumberGenerator;
        private readonly IPrimeNumberChecker _primeNumberChecker;

        public PrimeNumberService(IPrimeNumberGenerator primeNumberGenerator, IPrimeNumberChecker primeNumberChecker)
        {
            _primeNumberGenerator = primeNumberGenerator;
            _primeNumberChecker = primeNumberChecker;
        }

        public async Task<CheckIsPrimeNumberServiceModelResponse> CheckIsPrimeNumber(CheckIsPrimeNumberServiceModelRequest request)
        {
            var isPrimeNumber = await _primeNumberChecker.CheckAsync(request.Number);
            var response = new CheckIsPrimeNumberServiceModelResponse(request.Number, isPrimeNumber);

            return response;
        }

        public async Task<GetNextIfNotPrimeOrCurrentServiceModelResponse> GetNextIfNotPrimeOrCurrent(GetNextIfNotPrimeOrCurrentServiceModelRequest request)
        {
            var isPrimeNumber = await _primeNumberChecker.CheckAsync(request.Number);

            var nextPrimeNumber = request.Number;

            if (!isPrimeNumber)
            {
                nextPrimeNumber = await _primeNumberGenerator.GetNextPrimeNumberAsync(request.Number);
            }

            var response = new GetNextIfNotPrimeOrCurrentServiceModelResponse(nextPrimeNumber);

            return response;
        }
    }
}
