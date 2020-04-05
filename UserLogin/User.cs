using System;

namespace UserLogin
{
    public class User
    {
        public User(string usernameI, string passwordI, string facNumberI, int userRoleI)
        {
            Username = usernameI;
            Password = passwordI;
            FacNumber = facNumberI;
            UserRole = userRoleI;
            Created = DateTime.Now;
            //Account will be active forever: 
            Expires = DateTime.MaxValue;
        }

        public string Username { get; }
        public string Password { get; }
        public string FacNumber { get; }
        public int UserRole { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
    }
}