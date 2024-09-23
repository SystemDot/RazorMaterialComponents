
namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Account
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Shared;
    using SystemDot.Web.Razor.MaterialComponents.Examples.Abstractions;
    using Microsoft.AspNetCore.Authentication;

    [Authorize]
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Account) });
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(AuthorisationConstants.CookieAuth);
            return RedirectToAction(nameof(Index), nameof(Home.Home));
        }
    }
}
