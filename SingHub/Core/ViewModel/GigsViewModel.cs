﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingHub.Core.Models;

namespace SingHub.Core.ViewModel
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
        public string SearchTerm { get; set; }
        public ILookup<int, Attendance> Attendances { get; set; }
    }
}