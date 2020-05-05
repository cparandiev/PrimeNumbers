using System.Threading.Tasks;

namespace PrimeNumbers.Application.Interfaces
{
    public interface IPrimeNumberChecker
    {
        Task<bool> CheckAsync(int number);
    }
}
