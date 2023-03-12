using datingApp10.DTOs;
using datingApp10.Entities;
using datingApp10.Helpers;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace datingApp10.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likeUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}
