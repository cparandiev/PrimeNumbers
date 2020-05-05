using Microsoft.AspNetCore.Mvc;
using PrimeNumbers.API.Models.Requests;
using PrimeNumbers.API.Models.Responses;
using PrimeNumbers.Application.Interfaces;
using PrimeNumbers.Application.Models.ServiceModels;
using System.Threading.Tasks;

namespace PrimeNumbers.API.Controllers
{
    [Route("api/prime-numbers")]
    public class PrimeNumberController : BaseController
    {
        private readonly IPrimeNumberService _primeNumberService;

        public PrimeNumberController(IPrimeNumberService primeNumberService)
        {
            _primeNumberService = primeNumberService;
        }

        [HttpGet("next")]
        public async Task<ActionResult<GetNextIfNotPrimeOrCurrentResponse>> Next([FromQuery] GetNextIfNotPrimeOrCurrentRequest request)
        {
            var response = await _primeNumberService.GetNextIfNotPrimeOrCurrent(Mapper.Map<GetNextIfNotPrimeOrCurrentServiceModelRequest>(request));
            return Mapper.Map<GetNextIfNotPrimeOrCurrentResponse>(response);
        }

        [HttpGet("check")]
        public async Task<ActionResult<CheckIsPrimeNumberResponse>> Check([FromQuery] CheckIsPrimeNumberRequest request)
        {
            var response = await _primeNumberService.CheckIsPrimeNumber(Mapper.Map<CheckIsPrimeNumberServiceModelRequest>(request));
            return Mapper.Map<CheckIsPrimeNumberResponse>(response);
        }
    }
}