using MediatR;
using Titanium.Library.Models;

namespace Titanium.Library.Commands
{
    public record InsertUserCommand(UserModel UserData) : IRequest<UserModel>;
}
