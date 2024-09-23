namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Abstractions
{
    public record ColourData
    {
        public Colour Colour { get; init; }
        public Month Month { get; init; }
        public int Value { get; init; }
    }
}
