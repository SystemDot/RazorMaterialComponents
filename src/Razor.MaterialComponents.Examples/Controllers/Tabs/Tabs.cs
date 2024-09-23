using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Tabs
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Tabs : Controller
    {
        public IActionResult Index(int tab = 0)
        {
            return View(new TabsModel { SelectedTab = tab, ControllerName = nameof(Tabs) });
        }
    }
}
