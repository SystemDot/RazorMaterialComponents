using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Grids
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Grids : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Grids) });
        }
    }
}
