using CodeFlowCore.DTO;
using CodeFlowCore.Models;

namespace CodeFlowCore.Repos
{
    public class AuthRepo : IAuthRepo
    {
        public AuthUser Login(LoginDto loginDto)
        {
            if (loginDto == null) throw new ArgumentNullException("");

            if(loginDto.UserName=="admin" || loginDto.Password=="admin")
            {
                return new AuthUser() { UserName = loginDto.UserName };
            }

            throw new InvalidDataException("Invalid user");
        }
    }
}
