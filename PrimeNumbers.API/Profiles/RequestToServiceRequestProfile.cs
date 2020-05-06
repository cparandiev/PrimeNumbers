using AutoMapper;
using PrimeNumbers.API.Models.Requests;
using PrimeNumbers.Application.Models.Requests;

namespace PrimeNumbers.API.Profiles
{
    public class RequestToServiceRequestProfile : Profile
    {
        public RequestToServiceRequestProfile()
        {
            CreateMap<CheckIsPrimeNumberRequest, CheckIsPrimeNumberServiceRequest>();
            CreateMap<GetNextIfNotPrimeOrCurrentRequest, GetNextIfNotPrimeOrCurrentServiceRequest>();
        }
    }
}
