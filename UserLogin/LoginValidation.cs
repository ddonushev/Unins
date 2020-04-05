using System;

namespace UserLogin
{
    public class LoginValidation
    {
        public delegate void ActionOnError(string errorMessage);

        private static string _username;
        public static string CurrentUserUsername = _username;

        private readonly ActionOnError _actionOnError;

        private readonly string _password;
        private string _errorMessage;

        public LoginValidation(string usernameI, string passwordI, ActionOnError actionOnErrorI)
        {
            _username = usernameI;
            _password = passwordI;
            _actionOnError = actionOnErrorI;
        }

        public static UserRoles CurrentUserRole { get; private set; }

        public bool ValidateUserInput(out User userI)
        {
            if (_username.Length < 5)
            {
                userI = null;
                _actionOnError("The entered username is too short");
                return false;
            }

            if (_password.Length < 5)
            {
                userI = null;
                _actionOnError("The entered password is too short");
                return false;
            }

            userI = UserData.IsUserPassCorrect(_username, _password);
            if (userI == null)
            {
                _actionOnError("No match found for this password/username combination.");
                CurrentUserRole = UserRoles.Anonymous;
                return false;
            }

            CurrentUserRole = (UserRoles) userI.UserRole;
            _errorMessage = "Login successful.";
            Console.WriteLine(_errorMessage);
            Logger.LogActivity("Login successful.");
            return true;
        }
    }
}