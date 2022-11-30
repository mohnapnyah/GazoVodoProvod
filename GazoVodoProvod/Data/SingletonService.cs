using System.Collections.Generic;
namespace GazoVodoProvod.Data;
 public class SingletonService
 {
    User user;

    public User GetUser()
    {

        return user;
    }
    public void SetUser(User newUser)
    {
        user = newUser;
    }
 }


