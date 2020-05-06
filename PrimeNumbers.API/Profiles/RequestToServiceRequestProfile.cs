using AutoMapper;
using PrimeNumbers.API.Models.Requests;
using PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber;
using PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent;

namespace PrimeNumbers.API.Profiles
{
    public class RequestToServiceRequestProfile : Profile
    {
        public RequestToServiceRequestProfile()
        {
            CreateMap<CheckIsPrimeNumberRequest, CheckIsPrimeNumberQuery>();
            CreateMap<GetNextIfNotPrimeOrCurrentRequest, GetNextIfNotPrimeOrCurrentQuery>();
        }
    }
}
