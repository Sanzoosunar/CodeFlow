namespace CodeFlowCore.Models
{
    public class AuthUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public IEnumerable<AuthRoles> Roles { get; set; }

       
        // Override Equals
        public override bool Equals(object obj)
        {
            if (obj is AuthUser otherUser)
            {
                //return string.Equals(UserName, otherUser.UserName) && string.Equals(Password, otherUser.Password);
                return string.Equals(UserName, otherUser.UserName);
            }
            return false;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(UserName);
        }

        // Override ToString
        public override string ToString()
        {
            return $"UserName: {UserName}, Password: {new string('*', Password?.Length ?? 0)}";
        }

    }
}
