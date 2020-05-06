using Microsoft.AspNetCore.Mvc;
using PrimeNumbers.API.Models.Requests;
using PrimeNumbers.API.Models.Responses;
using PrimeNumbers.Application.PrimeNumber.Queries.CheckIsPrimeNumber;
using PrimeNumbers.Application.PrimeNumber.Queries.GetNextIfNotPrimeOrCurrent;
using System.Threading.Tasks;

namespace PrimeNumbers.API.Controllers
{
    [Route("api/prime-numbers")]
    public class PrimeNumberController : BaseController
    {
        /// <summary>
        /// Returns the next prime number which is greater or equal to the given number.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/prime-numbers/next?Number=7
        ///
        /// </remarks>
        /// <param name="request"></param>
        /// <returns>The next prime number</returns>
        /// <response code="200">Returns the next prime number</response>
        /// <response code="400">Returns the user error</response>
        [HttpGet("next")]
        public async Task<ActionResult<GetNextIfNotPrimeOrCurrentResponse>> Next([FromQuery] GetNextIfNotPrimeOrCurrentRequest request)
        {
            var query = Mapper.Map<GetNextIfNotPrimeOrCurrentQuery>(request);
            var nextPrimeNumberVm = await Mediator.Send(query);
            var response = Mapper.Map<GetNextIfNotPrimeOrCurrentResponse>(nextPrimeNumberVm);

            return response;
        }

        /// <summary>
        /// Determines if the given number is a prime number.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/prime-numbers/check?Number=7
        ///
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <response code="200">Returns result if the the given number is a prime number</response>
        /// <response code="400">Returns the user error</response>
        [HttpGet("check")]
        public async Task<ActionResult<CheckIsPrimeNumberResponse>> Check([FromQuery] CheckIsPrimeNumberRequest request)
        {
            var query = Mapper.Map<CheckIsPrimeNumberQuery>(request);
            var primeNumberVm = await Mediator.Send(query);
            var response = Mapper.Map<CheckIsPrimeNumberResponse>(primeNumberVm);

            return response;
        }
    }
}