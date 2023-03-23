using System.Threading;
using System.Threading.Tasks;
using BasicCleanArch.Application.Features.UserFeatures.GetAllUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace BasicCleanArch.WebAPI.Controllers
{
    [ApiController]
    [Route("string")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var response = _mediator.Send(new GetAllUserRequest(), cancellationToken);
            return View();
        }
    }
}
