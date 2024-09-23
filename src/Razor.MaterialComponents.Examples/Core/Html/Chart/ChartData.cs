namespace SystemDot.Web.Razor.MaterialComponents.Examples.Core.Html.Chart
{
    public record ChartData
    {
        public IEnumerable<string>? Labels { get; init; }
        public required IEnumerable<ChartDataset> Datasets { get; init; }
    }
}
