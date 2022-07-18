using Titanium.Library.Models;

namespace Titanium.Library.DataAccess
{
    public class UsersDataAccess : IUsersDataAccess
    {
        private readonly List<UserModel> UsersList = new();

        public UsersDataAccess()
        {
            UsersList.Add(new UserModel { Id = 1, Name = "Paul", LastName = "Wells", Age = 32, Email = "Paul.Wells@gmail.com" });
            UsersList.Add(new UserModel { Id = 2, Name = "Json", LastName = "Stark", Age = 39, Email = "Json.Stark@gmail.com" });
            UsersList.Add(new UserModel { Id = 3, Name = "Tim", LastName = "Node", Age = 16, Email = "Tim.Node@gmail.com" });
            UsersList.Add(new UserModel { Id = 4, Name = "Pablo", LastName = "Nuguri", Age = 47, Email = "Pablo.Nuguri@gmail.com" });
            UsersList.Add(new UserModel { Id = 5, Name = "Sasha", LastName = "Nitksy", Age = 22, Email = "Sasha.Nitksy@gmail.com" });
        }

        public List<UserModel> GetUsers()
        {
            return UsersList;
        }

        public UserModel GetUser(int id)
        {
            return UsersList.First(x => x.Id == id);
        }

        public UserModel InsertUser(UserModel userModel)
        {
            UserModel user = new()
            {
                Id = UsersList.Max(x => x.Id) + 1,
                Name = userModel.Name,
                LastName = userModel.LastName,
                Age = userModel.Age,
                Email = userModel.Email
            };
            UsersList.Add(user);
            return user;
        }
    }
}
