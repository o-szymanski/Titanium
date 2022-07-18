using MediatR;
using Titanium.Library.Commands;
using Titanium.Library.DataAccess;
using Titanium.Library.Models;

namespace Titanium.Library.Handlers
{
    internal class InsertUserHandler : IRequestHandler<InsertUserCommand, UserModel>
    {
        private readonly IUsersDataAccess _usersDataAccess;

        public InsertUserHandler(IUsersDataAccess usersDataAccess)
        {
            _usersDataAccess = usersDataAccess;
        }

        public Task<UserModel> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_usersDataAccess.InsertUser(request.UserData));
        }
    }
}
