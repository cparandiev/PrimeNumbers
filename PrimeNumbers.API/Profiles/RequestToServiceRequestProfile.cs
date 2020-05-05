using AutoMapper;
using PrimeNumbers.API.Models.Requests;
using PrimeNumbers.Application.Models.ServiceModels;

namespace PrimeNumbers.API.Profiles
{
    public class RequestToServiceRequestProfile : Profile
    {
        public RequestToServiceRequestProfile()
        {
            CreateMap<CheckIsPrimeNumberRequest, CheckIsPrimeNumberServiceModelRequest>();
            CreateMap<GetNextIfNotPrimeOrCurrentRequest, GetNextIfNotPrimeOrCurrentServiceModelRequest>();
        }
    }
}
