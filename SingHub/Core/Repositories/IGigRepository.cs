using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingHub.Core.Models;

namespace SingHub.Core.Repositories
{
    public interface IGigRepository
    {
        Gig GetGig(int gigId);
        IEnumerable<Gig> GetUpcomingGigsByArtist(string artistId);
        Gig GetGigWithAttendee(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        void Add(Gig gig);
    }
}
