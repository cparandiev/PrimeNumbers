using PrimeNumbers.Application.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbers.Toolbox
{
    public class PrimeNumberChecker : IPrimeNumberChecker
    {
        private IEnumerable<int> GetNumbersDigit(int number)
        {
            List<int> listOfInts = new List<int>();
            
            while (number > 0)
            {
                listOfInts.Add(number % 10);
                number = number / 10;
            }
            
            listOfInts.Reverse();
            
            return listOfInts;
        }
        public Task<bool> CheckAsync(int number)
        {
            if (number <= 1)
            {
                return Task.FromResult(false);
            }

            if (number >= 10)
            {
                var lastDigit = number % 10;

                if (lastDigit == 0 || lastDigit == 2 || lastDigit == 5)
                {
                    return Task.FromResult(false);
                }

                if(GetNumbersDigit(number).Sum() % 3 == 0)
                {
                    return Task.FromResult(false);
                }
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return Task.FromResult(false);
                }
            }

            return Task.FromResult(true);
        }
    }
}
