using CodeFlowCore.DTO;
using CodeFlowCore.Models;

namespace CodeFlowCore.Repos
{
    public interface IAuthRepo
    {
        public AuthUser Login(LoginDto loginDto);
    }
}
