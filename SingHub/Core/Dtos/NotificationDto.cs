using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SingHub.Core.Models;

namespace SingHub.Core.Dtos
{
    public class NotificationDto
    {
        public DateTime DateTime { get; set; }
        public NotificationType Type { get; set; }
        public DateTime? OriginalDatetime { get; set; }
        public string OriginalVenue { get; set; }
        public GigDto Gig { get; set; }

    }
}