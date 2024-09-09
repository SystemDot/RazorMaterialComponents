namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Options
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

    public record OptionsModel : MenuModel
    {
        public bool CheckboxValue { get; set; }
        public bool SwitchValue { get; set; }
        public int RadioValue { get; set; }
    }
}