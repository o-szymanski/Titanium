using MediatR;
using Titanium.Library.Models;

namespace Titanium.Library.Queries
{
    public record GetUsersQuery() : IRequest<List<UserModel>>;
}
