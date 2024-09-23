using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Banners;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Buttons;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Cards;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Chips;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Fields;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Options;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Charts;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Text;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Grids;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Tabs;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Account;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.DataTables;
using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Dialogs;

namespace SystemDot.Web.Razor.MaterialComponents.Examples.Views.Shared;

public static class CustomMenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
    [
        MenuItem.CreateMenuItem(nameof(Charts), "trending_up", controllerName),
        MenuItem.CreateMenuItem(nameof(Fields), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Chips), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Options), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Banners), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Buttons), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Text), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Grids), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Cards), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Tabs), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(DataTables), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Dialogs), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Account), "description", controllerName)
    ]; 
}