using System.Threading.Tasks;

namespace PrimeNumbers.Application.Common.Interfaces
{
    public interface IPrimeNumberChecker
    {
        Task<bool> CheckAsync(int number);
    }
}
