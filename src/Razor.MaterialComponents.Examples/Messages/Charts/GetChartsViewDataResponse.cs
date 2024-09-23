namespace SystemDot.Web.Razor.MaterialComponents.Examples.Messages.Charts
{
    using SystemDot.Web.Razor.MaterialComponents.Examples.Abstractions;

    public record GetChartsViewDataResponse
    {
        public required IEnumerable<int> Data { get; init; }
        public required IEnumerable<string> Labels { get; init; }
        public required IEnumerable<string> Colours { get; init; }
        public required IEnumerable<Month> Months { get; init; }
    }
}
