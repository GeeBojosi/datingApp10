using datingApp10.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace datingApp10.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
