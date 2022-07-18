using Titanium.Library.Models;

namespace Titanium.Library.DataAccess
{
    public interface IUsersDataAccess
    {
        UserModel GetUser(int id);
        List<UserModel> GetUsers();
        UserModel InsertUser(UserModel userModel);
    }
}
