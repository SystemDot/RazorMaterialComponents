namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Options
{
    using SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Shared;

    public record OptionsModel : MenuModel
    {
        public bool CheckboxValue { get; set; }
        public bool SwitchValue { get; set; }
        public int RadioValue { get; set; }
    }
}