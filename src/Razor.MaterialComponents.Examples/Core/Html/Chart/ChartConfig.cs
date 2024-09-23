namespace SystemDot.Web.Razor.MaterialComponents.Examples.Core.Html.Chart
{
    public record ChartConfig
    {
        public required string Type { get; init; }
        public required ChartData Data { get; init; }
    }
}
