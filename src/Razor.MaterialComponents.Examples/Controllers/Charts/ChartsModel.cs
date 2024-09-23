namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Charts
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public record ChartsModel : MenuModel
    {
        public IEnumerable<int> Data { get; init; }
        public IEnumerable<string> Labels { get; init; }
        public IEnumerable<string> Colours { get; init; }
        public IEnumerable<SelectListItem> Months { get; init; }
        public string From { get; init; }
        public string To { get; init; }
    }
}
