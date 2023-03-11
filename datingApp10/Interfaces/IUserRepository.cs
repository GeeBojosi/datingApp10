using datingApp10.DTOs;
using datingApp10.Entities;
using datingApp10.Helpers;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace datingApp10.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllChangeAsync(); 
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetByUsernameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberAsync(string username);
    }
}
