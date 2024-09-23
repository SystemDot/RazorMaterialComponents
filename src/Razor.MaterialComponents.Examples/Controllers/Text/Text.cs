using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Text
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Text : Controller
    {
        public IActionResult Index()
        {
            return View(new TextModel { ControllerName = nameof(Text) });
        }
    }
}
