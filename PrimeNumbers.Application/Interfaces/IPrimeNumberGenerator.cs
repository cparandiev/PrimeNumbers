using System.Threading.Tasks;

namespace PrimeNumbers.Application.Interfaces
{
    public interface IPrimeNumberGenerator
    {
        Task<int> GetNextPrimeNumberAsync(int number);
    }
}
