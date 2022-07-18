using MediatR;
using Titanium.Library.DataAccess;
using Titanium.Library.Models;
using Titanium.Library.Queries;

namespace Titanium.Library.Handlers
{
    internal class GetUserHandler : IRequestHandler<GetUserQuery, UserModel>
    {
        private readonly IUsersDataAccess _userDataAccess;

        public GetUserHandler(IUsersDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public Task<UserModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_userDataAccess.GetUser(request.Id));
        }
    }
}
