using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Context;
using FitnessApp.Models;

namespace FitnessApp.Business.Handlers
{
    public class UserService
    {
      public void CreateUser(UserProfile profile)
      {
        UserContext.CreateUser(profile);
      }

      public bool IsUsernameExist(string username)
      {
        return UserContext.IsUserExistForUserName(username);
      }

      public void Logout()
      {
        UserContext.Logout();
      }

      public string GetUserFirstName()
      {
        return UserContext.GetUserFirstName();
      }

      public UserProfile GetUserProfile()
      {
        return UserContext.CurrentProfile;
      }
    }
}
