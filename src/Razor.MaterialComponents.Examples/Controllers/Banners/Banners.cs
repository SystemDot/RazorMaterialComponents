﻿using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Banners
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Banners : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Banners) });
        }
    }
}
