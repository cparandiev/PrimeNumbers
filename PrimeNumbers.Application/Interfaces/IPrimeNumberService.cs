using PrimeNumbers.Application.Models.Requests;
using PrimeNumbers.Application.Models.Responses;
using System.Threading.Tasks;

namespace PrimeNumbers.Application.Interfaces
{
    public interface IPrimeNumberService
    {
        Task<CheckIsPrimeNumberServiceResponse> CheckIsPrimeNumber(CheckIsPrimeNumberServiceRequest request);
        
        Task<GetNextIfNotPrimeOrCurrentServiceResponse> GetNextIfNotPrimeOrCurrent(GetNextIfNotPrimeOrCurrentServiceRequest request);
    }
}
