using AutoMapper;
using PrimeNumbers.API.Models.Responses;
using PrimeNumbers.Application.Models.ServiceModels;

namespace PrimeNumbers.API.Profiles
{
    public class ServiceResponseToResponseProfile : Profile
    {
        public ServiceResponseToResponseProfile()
        {
            CreateMap<GetNextIfNotPrimeOrCurrentServiceModelResponse, GetNextIfNotPrimeOrCurrentResponse>();
            CreateMap<CheckIsPrimeNumberServiceModelResponse, CheckIsPrimeNumberResponse>();
        }
    }
}
