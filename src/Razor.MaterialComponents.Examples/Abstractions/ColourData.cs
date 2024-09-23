﻿namespace SystemDot.Web.Razor.MaterialComponents.Examples.Abstractions
{
    public record ColourData
    {
        public required Colour Colour { get; init; }
        public required Month Month { get; init; }
        public required int Value { get; init; }
    }
}
