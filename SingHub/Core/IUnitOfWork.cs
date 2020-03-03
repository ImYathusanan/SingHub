using SingHub.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SingHub.Core
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }

        IAttendanceRepository Attendances { get; }

        IFollowingRepository Followings { get; }

        IGenreRepository Genres { get; }

        IApplicationUserRepository Users { get; }

        void Complete();
    }
}
