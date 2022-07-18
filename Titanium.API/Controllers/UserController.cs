using MediatR;
using Microsoft.AspNetCore.Mvc;
using Titanium.Library.Commands;
using Titanium.Library.Models;
using Titanium.Library.Queries;

namespace Titanium.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<UserModel>> Get() => await _mediator.Send(new GetUsersQuery());

        [HttpGet("{id}")]
        public async Task<UserModel> GetById(int id) => await _mediator.Send(new GetUserQuery(id));

        [HttpPost]
        public async Task<UserModel> Post([FromBody] UserModel userModel) => await _mediator.Send(new InsertUserCommand(userModel));
    }
}