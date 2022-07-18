using MediatR;
using Titanium.Library.DataAccess;
using Titanium.Library.Models;
using Titanium.Library.Queries;

namespace Titanium.Library.Handlers
{
    internal class GetUsersHandler : IRequestHandler<GetUsersQuery, List<UserModel>>
    {
        private readonly IUsersDataAccess _userDataAccess;

        public GetUsersHandler(IUsersDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public Task<List<UserModel>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_userDataAccess.GetUsers());
        }
    }
}
