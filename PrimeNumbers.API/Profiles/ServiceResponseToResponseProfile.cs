using AutoMapper;
using PrimeNumbers.API.Models.Responses;
using PrimeNumbers.Application.Models.Responses;

namespace PrimeNumbers.API.Profiles
{
    public class ServiceResponseToResponseProfile : Profile
    {
        public ServiceResponseToResponseProfile()
        {
            CreateMap<GetNextIfNotPrimeOrCurrentServiceResponse, GetNextIfNotPrimeOrCurrentResponse>();
            CreateMap<CheckIsPrimeNumberServiceResponse, CheckIsPrimeNumberResponse>();
        }
    }
}
