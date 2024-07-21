using HightScore.Entities.Model.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HightScore.Controllers
{
    public class CreateUser : Controller
    {
        private UserManager<MetaUser> _userManager;
        public CreateUser(UserManager<MetaUser> userManager)
        {
            _userManager = userManager;
        }



    }

}



