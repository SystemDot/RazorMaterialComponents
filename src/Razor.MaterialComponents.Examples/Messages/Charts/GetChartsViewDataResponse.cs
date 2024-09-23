namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Messages.Charts
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Abstractions;

    public record GetChartsViewDataResponse
    {
        public IEnumerable<int> Data { get; init; }
        public IEnumerable<string> Labels { get; init; }
        public IEnumerable<string> Colours { get; init; }
        public IEnumerable<Month> Months { get; init; }
    }
}
