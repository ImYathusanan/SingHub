using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingHub.Core.Models;
using SingHub.Core.Repositories;

namespace SingHub.Persistence.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private readonly ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Following GetFollowing(string followerId, string followeeId)
        {
            return _context
                .Followings.SingleOrDefault(f => f.FolloweeId == followeeId && f.FollowerId == followerId);
        }

       
    }
}