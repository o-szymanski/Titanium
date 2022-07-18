using MediatR;
using Titanium.Library.Models;

namespace Titanium.Library.Queries
{
    public record GetUserQuery(int Id) : IRequest<UserModel>;
}
