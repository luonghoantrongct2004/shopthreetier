using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Shop.DAL.Entity.Identity;
using ShopDataAccess.Models;
using System.Security.Policy;
using System.Text;

namespace Shop.BLL.Service
{
    public class AuthService
    {
        private readonly UserManager<ShopUser> _userManager;
        private readonly SignInManager<ShopUser> _signInManage;

        public AuthService(UserManager<ShopUser> userManager, SignInManager<ShopUser> signInManage)
        {
            _userManager = userManager;
            _signInManage = signInManage;
        }
        public async Task<IdentityResult> RegisterUserAsync(RegisterViewModel model, string returnUrl = null)
        {
            var user = new ShopUser { UserName = model.UserName, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _signInManage.SignInAsync(user, isPersistent: false);
            }
            return result;
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model, string returnUrl = null)
        {
            var result = await _signInManage.PasswordSignInAsync(model.UserNameOrEmail, model.Password, model.RememberMe, lockoutOnFailure: true);
            return result;
        }
    }
}
