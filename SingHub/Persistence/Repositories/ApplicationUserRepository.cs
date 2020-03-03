
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingHub.Core.Models;
using SingHub.Core.Repositories;

namespace SingHub.Persistence.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ApplicationUser> GetArtistFollowedBy(string userId)
        {
            return _context.Followings
               .Where(f => f.FollowerId == userId)
               .Select(f => f.Followee)
               .ToList();
        }
    }
}