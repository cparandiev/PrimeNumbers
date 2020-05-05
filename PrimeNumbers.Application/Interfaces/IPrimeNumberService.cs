using PrimeNumbers.Application.Models.ServiceModels;
using System.Threading.Tasks;

namespace PrimeNumbers.Application.Interfaces
{
    public interface IPrimeNumberService
    {
        Task<CheckIsPrimeNumberServiceModelResponse> CheckIsPrimeNumber(CheckIsPrimeNumberServiceModelRequest request);
        
        Task<GetNextIfNotPrimeOrCurrentServiceModelResponse> GetNextIfNotPrimeOrCurrent(GetNextIfNotPrimeOrCurrentServiceModelRequest request);
    }
}
