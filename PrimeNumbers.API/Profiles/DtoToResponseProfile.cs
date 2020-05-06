using AutoMapper;
using PrimeNumbers.API.Models.Responses;
using PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber;
using PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent;

namespace PrimeNumbers.API.Profiles
{
    public class DtoToResponseProfile : Profile
    {
        public DtoToResponseProfile()
        {
            CreateMap<NextPrimeNumberDto, GetNextIfNotPrimeOrCurrentResponse>();
            CreateMap<PrimeNumberDto, CheckIsPrimeNumberResponse>();
        }
    }
}
