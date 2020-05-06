using FluentValidation;

namespace PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent
{
    public class GetNextIfNotPrimeOrCurrentQueryValidator : AbstractValidator<GetNextIfNotPrimeOrCurrentQuery>
    {
        public GetNextIfNotPrimeOrCurrentQueryValidator()
        {
            RuleFor(x => x.Number)
                .NotNull();
        }
    }
}
