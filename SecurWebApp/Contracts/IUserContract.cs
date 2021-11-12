using SecurDataAccessLayer.Externals.LoginExternals;
using SecurDataAccessLayer.Externals.UserExternals;
using SecurDataAccessLayer.Models;
using System.Collections.Generic;

namespace SecurWebApp.Contracts
{
    public interface IUserContract
    {
        IEnumerable<User> GetUsers();

        User GetUser(int id);

        void CreateUser(User user);

        void UpdateUser(User user, UpdateUser updateUser);

        void DeleteUser(User user);

        bool SaveChanges();

        bool IsLoggedIn(int userId, int jwtClaimUserId);

        string Authenticate(Credentials credentials);
    }
}