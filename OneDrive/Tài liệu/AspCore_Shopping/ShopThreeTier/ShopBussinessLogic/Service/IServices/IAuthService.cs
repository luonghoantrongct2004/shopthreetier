using Microsoft.AspNetCore.Identity;
using Shop.DAL.Entity.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Service.IServices
{
    public interface IAuthService
    {

        Task<IdentityResult> RegisterUserAsync (RegisterViewModel model, string returnUrl = null);
        Task<SignInResult> LoginAsync(LoginViewModel model);

    }
}
