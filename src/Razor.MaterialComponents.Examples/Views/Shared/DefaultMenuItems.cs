using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Home;

namespace SystemDot.Web.Razor.MaterialComponents.Examples.Views.Shared;

public static class DefaultMenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
    [
        MenuItem.CreateMenuItem(nameof(Home), "home", controllerName),
    ];
}