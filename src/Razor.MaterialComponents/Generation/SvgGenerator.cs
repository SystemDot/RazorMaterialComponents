using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class SvgGenerator
    {
        public static TagBuilder GenerateCheckboxCheckmark()
        {
            return GenerateSvg("mdc-checkbox__checkmark", "0 0 24 24");
        }

        public static TagBuilder GenerateCheckboxCheckmarkPath()
        {
            return GenerateSvgPath("mdc-checkbox__checkmark-path", true, "M1.73,12.91 8.1,19.28 22.79,4.59");
        }

        public static TagBuilder GenerateSelectDropdown()
        {
            return GenerateSvg("mdc-select__dropdown-icon-graphic", "7 10 10 5");
        }

        public static TagBuilder GenerateSwitchOn()
        {
            return GenerateSvg("mdc-switch__icon mdc-switch__icon--on", "0 0 24 24");
        }

        public static TagBuilder GenerateSwitchOnPath()
        {
            return GenerateSvgPath("M19.69,5.23L8.96,15.96l-4.23-4.23L2.96,13.5l6,6L21.46,7L19.69,5.23z");
        }

        public static TagBuilder GenerateSwitchOff()
        {
            return GenerateSvg("mdc-switch__icon mdc-switch__icon--off", "0 0 24 24");
        }

        public static TagBuilder GenerateSwitchOffPath()
        {
            return GenerateSvgPath("M20 13H4v-2h16v2z");
        }

        public static TagBuilder GenerateSelectDropdownInactivePolygon()
        {
            return GenerateSvgPolygon("mdc-select__dropdown-icon-inactive", "7 10 12 15 17 10");
        }

        public static TagBuilder GenerateSelectDropdownActivePolygon()
        {
            return GenerateSvgPolygon("mdc-select__dropdown-icon-active", "7 15 12 10 17 15");
        }

        public static TagBuilder GenerateSvg(string cssClass, string viewBox)
        {
            var builder = new TagBuilder("svg");
            builder.AddCssClass(cssClass);
            builder.Attributes.Add("viewBox", viewBox);
            return builder;
        }

        public static TagBuilder GenerateSvgPolygon(string cssClass, string points)
        {
            var builder = new TagBuilder("polygon");
            builder.AddCssClass(cssClass);
            builder.Attributes.Add("stroke", "none");
            builder.Attributes.Add("fill-rule", "evenodd");
            builder.Attributes.Add("points", points);
            return builder;
        }

        public static TagBuilder GenerateSvgPath(string cssClass, bool fillNone, string points)
        {
            var builder = GenerateSvgPath(points);
            builder.AddCssClass(cssClass);
            if (fillNone)
            {
                builder.Attributes.Add("fill", "none");
            }
            return builder;
        }

        public static TagBuilder GenerateSvgPath(string points)
        {
            var builder = new TagBuilder("path");
            builder.Attributes.Add("d", points);
            return builder;
        }
    }
}
