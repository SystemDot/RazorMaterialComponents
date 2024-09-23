namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Tabs
{
    using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Shared;

    public record TabsModel : MenuModel
    {
        public int SelectedTab { get; init; }
    }
}