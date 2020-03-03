using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SingHub.Core;

namespace SingHub.Controllers
{
    public class FolloweesController : Controller
    {

        private IUnitOfWork _unitOfWork;

        public FolloweesController(IUnitOfWork unitOfWork)
        {
            unitOfWork = unitOfWork;
        }
        // GET: Followees
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var artist = _unitOfWork.Users.GetArtistsFollowedBy(userId);
            
            return View(artist);
        }
    }
}