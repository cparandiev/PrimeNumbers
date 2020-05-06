using FluentValidation;

namespace PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber
{
    public class CheckIsPrimeNumberQueryValidator : AbstractValidator<CheckIsPrimeNumberQuery>
    {
        public CheckIsPrimeNumberQueryValidator()
        {
            RuleFor(x => x.Number)
                .NotNull();
        }
    }
}
