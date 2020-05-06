using AutoMapper;
using PrimeNumbers.API.Models.Responses;
using PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber;
using PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent;

namespace PrimeNumbers.API.Profiles
{
    public class ServiceResponseToResponseProfile : Profile
    {
        public ServiceResponseToResponseProfile()
        {
            CreateMap<NextPrimeNumberVm, GetNextIfNotPrimeOrCurrentResponse>();
            CreateMap<PrimeNumberVm, CheckIsPrimeNumberResponse>();
        }
    }
}
