using System.Threading.Tasks;

namespace PrimeNumbers.Application.Common.Interfaces
{
    public interface IPrimeNumberGenerator
    {
        Task<int> GetNextPrimeNumberAsync(int number);
    }
}
