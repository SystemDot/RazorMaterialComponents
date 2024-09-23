using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Cards
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Cards : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Cards) });
        }
    }
}
