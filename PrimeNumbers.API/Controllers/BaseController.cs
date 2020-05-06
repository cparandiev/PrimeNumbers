using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace PrimeNumbers.API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private IMapper _mapper;
        private IMediator _mediator;

        protected IMapper Mapper => _mapper ?? (_mapper = HttpContext.RequestServices.GetService<IMapper>());

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}