using Microsoft.AspNetCore.Identity;
using ShopDataAccess.Models;

namespace Shop.BLL.Service
{
    public class IdentityService
    {
        private readonly UserManager<ShopUser> _userManager;
        private readonly SignInManager<ShopUser> _signInManager;

        public IdentityService(UserManager<ShopUser> userManager, SignInManager<ShopUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
    }
}
