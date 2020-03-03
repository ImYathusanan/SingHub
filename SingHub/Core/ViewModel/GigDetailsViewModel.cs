using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingHub.Core.Models;

namespace SingHub.Core.ViewModel
{
    public class GigDetailsViewModel
    {
        public Gig Gig { get; set; }
        public bool IsAttending { get; set; }
        public bool IsFollowing { get; set; }
    }
}