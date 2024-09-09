using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Reflection.Emit;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class SwitchGenerator
    {
        public static TagBuilder GenerateSwitch(string? id, MdcElementMode mode, ModelExpression? @for, bool disabled)
        {
            if (mode == MdcElementMode.Exploded)
            {
                return GenerateSwitchExploded(id, @for, disabled);
            }
            else
            {
                return GenerateSwitchContained(id, @for, disabled);
            }
        }

        private static TagBuilder GenerateSwitchExploded(string? id, ModelExpression? @for, bool disabled)
        {
            return ButtonGenerator.GenerateSwitchButton(id, @for, disabled);
        }

        private static TagBuilder GenerateSwitchContained(string? id, ModelExpression? @for, bool disabled)
        {            
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var builder = ButtonGenerator.GenerateSwitchButton(id, @for, disabled);
            HtmlContentBuilder content = new HtmlContentBuilder();

            content.AppendLine(GenerateSwitchTrack());
            TagBuilder handleTrackBuilder = GenerateSwitchHandleTrack();

            TagBuilder handleBuilder = GenerateSwitchHandle();
            HtmlContentBuilder handleContent = new HtmlContentBuilder();

            TagBuilder shadowBuilder = GenerateSwitchShadow();
            shadowBuilder.InnerHtml.SetHtmlContent(OverlayGenerator.GenerateElevationOverlay());

            handleContent.AppendLine(shadowBuilder);
            handleContent.AppendLine(RippleGenerator.GenerateSwitchRipple());

            TagBuilder iconsBuilder = GenerateSwitchIcons();
            HtmlContentBuilder iconsContent = new HtmlContentBuilder();

            TagBuilder svgOnBuilder = SvgGenerator.GenerateSwitchOn();
            svgOnBuilder.InnerHtml.SetHtmlContent(SvgGenerator.GenerateSwitchOnPath());
            iconsContent.AppendLine(svgOnBuilder);

            TagBuilder svgOffBuilder = SvgGenerator.GenerateSwitchOff();
            svgOffBuilder.InnerHtml.SetHtmlContent(SvgGenerator.GenerateSwitchOffPath());
            iconsContent.AppendLine(svgOffBuilder);

            iconsBuilder.InnerHtml.SetHtmlContent(iconsContent);
            handleContent.AppendLine(iconsBuilder);

            handleBuilder.InnerHtml.SetHtmlContent(handleContent);

            handleTrackBuilder.InnerHtml.SetHtmlContent(handleBuilder);
            content.AppendLine(handleTrackBuilder);

            builder.InnerHtml.SetHtmlContent(content);
            return builder;
        }

        public static TagBuilder GenerateSwitchTrack()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-switch__track");
            return builder;
        }

        public static TagBuilder GenerateSwitchHandleTrack()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-switch__handle-track");
            return builder;
        }

        public static TagBuilder GenerateSwitchHandle()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-switch__handle");
            return builder;
        }

        public static TagBuilder GenerateSwitchShadow()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-switch__shadow");
            return builder;
        }

        public static TagBuilder GenerateSwitchIcons()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-switch__icons");
            return builder;
        }
    }
}
