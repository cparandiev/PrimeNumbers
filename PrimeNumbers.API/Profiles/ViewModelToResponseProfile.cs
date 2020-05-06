using AutoMapper;
using PrimeNumbers.API.Models.Responses;
using PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber;
using PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent;

namespace PrimeNumbers.API.Profiles
{
    public class ViewModelToResponseProfile : Profile
    {
        public ViewModelToResponseProfile()
        {
            CreateMap<NextPrimeNumberVm, GetNextIfNotPrimeOrCurrentResponse>();
            CreateMap<PrimeNumberVm, CheckIsPrimeNumberResponse>();
        }
    }
}
