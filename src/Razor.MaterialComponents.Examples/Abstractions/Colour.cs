namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Abstractions
{
    public record Colour
    {
        public static Colour Red { get; } = new Colour { Name = nameof(Red), R = 255, G = 99, B = 132 };
        public static Colour Blue { get; } = new Colour { Name = nameof(Blue), R = 54, G = 162, B = 235 };
        public static Colour Yellow { get; } = new Colour { Name = nameof(Yellow), R = 255, G = 205, B = 86 };
        public string Name { get; init; }
        public int R { get; init; }
        public int G { get; init; }
        public int B { get; init; }

        public string ToRgbValue() => $"rgb({R},{G},{B})";
    }
}
