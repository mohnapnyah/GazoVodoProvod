using System.Collections.Generic;

namespace GazoVodoProvod.Data;
 public class SingletonService
 {
    User user;
    Project project;

    public User GetUser()
    {

        return user;
    }
    public void SetUser(User newUser)
    {
        user = newUser;
    }

    public Project GetProject()
    {
        return project;
    }

    public void SetProject(Project project)
    {
        this.project = project;
    }
}


