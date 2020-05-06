using AutoMapper;
using PrimeNumbers.API.Models.Requests;
using PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber;
using PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent;

namespace PrimeNumbers.API.Profiles
{
    public class RequestToQueryProfile : Profile
    {
        public RequestToQueryProfile()
        {
            CreateMap<CheckIsPrimeNumberRequest, CheckIsPrimeNumberQuery>();
            CreateMap<GetNextIfNotPrimeOrCurrentRequest, GetNextIfNotPrimeOrCurrentQuery>();
        }
    }
}
