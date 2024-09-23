namespace SystemDot.Web.Razor.MaterialComponents.Examples.Views.Shared;

public static class MenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
        DefaultMenuItems
            .Get(controllerName)
            .Union(CustomMenuItems.Get(controllerName));
}