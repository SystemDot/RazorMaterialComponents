using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class OverlayGenerator
    {
        public static TagBuilder GenerateElevationOverlay()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-elevation-overlay");
            return builder;
        }
    }
}
