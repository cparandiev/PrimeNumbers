﻿using PrimeNumbers.Application.Common.Interfaces;
using System;
using System.Threading.Tasks;

namespace PrimeNumbers.Toolbox
{
    public class PrimeNumberGenerator : IPrimeNumberGenerator
    {
        private readonly IPrimeNumberChecker _primeNumberChecker;

        public PrimeNumberGenerator(IPrimeNumberChecker primeNumberChecker)
        {
            _primeNumberChecker = primeNumberChecker;
        }

        public async Task<int> GetNextPrimeNumberAsync(int number)
        {
            if(number == int.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            int i = number + 1;

            while (i <= int.MaxValue)
            {
                var isPrime = await _primeNumberChecker.CheckAsync(i);

                if (isPrime)
                {
                    return i;
                }

                i++;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
