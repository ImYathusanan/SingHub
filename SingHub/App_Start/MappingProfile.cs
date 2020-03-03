using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SingHub.Models;
using SingHub.Controllers.Api;

namespace SingHub.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
            Mapper.CreateMap<Gig, GigDto>();
            Mapper.CreateMap<Notification, NotificationDto>();
        }
    }
}