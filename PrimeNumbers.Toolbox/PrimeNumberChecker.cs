using PrimeNumbers.Application.Interfaces;
using System.Threading.Tasks;

namespace PrimeNumbers.Toolbox
{
    public class PrimeNumberChecker : IPrimeNumberChecker
    {
        public Task<bool> CheckAsync(int number)
        {
            if (number == 2 || number == 3)
            {
                return Task.FromResult(true);
            }

            for(int i = 2; i * i <= number; i++)
            {
                if(number % i == 0)
                {
                    return Task.FromResult(false);
                }
            }

            return Task.FromResult(true);
        }
    }
}
