namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Chips
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Chips : Controller
    {
        private readonly ChipModelCache cache;

        public Chips(ChipModelCache cache)
        {
            this.cache = cache;
        }

        public IActionResult Index()
        {
            ChipsModel model = cache.Get() ?? new ChipsModel();

            model = model with
            {
                ControllerName = nameof(Chips)
            };

            return base.View(model);
        }

        [HttpPost]
        public IActionResult Index(ChipsModel model)
        {
            cache.Set(model); 
            return RedirectToAction();
        }
    }
}
