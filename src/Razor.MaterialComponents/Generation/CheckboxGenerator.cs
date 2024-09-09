﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class CheckboxGenerator
    {
        public static TagBuilder GenerateCheckbox(string? id, string? label, MdcElementMode mode, ModelExpression? @for, bool touch)
        {
            if (mode == MdcElementMode.Exploded)
            {
                return GenerateCheckboxExploded(id, touch);
            }
            else
            {
                return GenerateCheckboxContained(id, label, @for, touch);
            }
        }

        private static TagBuilder GenerateCheckboxContained(string? id, string? label, ModelExpression? @for, bool touch)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (label is null)
            {
                throw new ArgumentNullException(nameof(label));
            }

            TagBuilder builder = FieldGenerator.GenerateFormField();
            HtmlContentBuilder content = new HtmlContentBuilder();

            TagBuilder containerBuilder = GenerateCheckboxContainer(touch);
            HtmlContentBuilder containerContent = new HtmlContentBuilder();
            
            TagBuilder inputBuilder = InputGenerator.GenerateCheckbox(@for);
            inputBuilder.Attributes.Add("id", id);
            containerContent.AppendLine(inputBuilder);

            TagBuilder backgroundBuilder = GenerateCheckboxBackground();
            HtmlContentBuilder backgroundContent = new HtmlContentBuilder();

            TagBuilder svgBuilder = SvgGenerator.GenerateCheckboxCheckmark();
            svgBuilder.InnerHtml.SetHtmlContent(SvgGenerator.GenerateCheckboxCheckmarkPath());
            backgroundContent.AppendLine(svgBuilder);
            backgroundContent.AppendLine(GenerateCheckboxMixedmark());

            backgroundBuilder.InnerHtml.SetHtmlContent(backgroundContent);

            containerContent.AppendLine(backgroundBuilder);
            containerContent.AppendLine(RippleGenerator.GenerateCheckboxRipple());

            containerBuilder.InnerHtml.SetHtmlContent(containerContent);

            content.AppendLine(containerBuilder);
            content.AppendLine(LabelGenerator.GenerateLabelFor(id, label));

            builder.InnerHtml.SetHtmlContent(content);
            return builder;
        }

        private static TagBuilder GenerateCheckboxExploded(string? id, bool touch)
        {
            TagBuilder builder = GenerateCheckboxContainer(touch);

            if (id is not null)
            {
                builder.Attributes.Add("id", id);
            }

            return builder;
        }

        public static TagBuilder GenerateCheckboxBackground()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-checkbox__background");
            return builder;
        }

        public static TagBuilder GenerateCheckboxMixedmark()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-checkbox__mixedmark");
            return builder;
        }

        private static TagBuilder GenerateCheckboxContainer(bool touch)
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-checkbox");
            builder.AddCssClass("mdc-checkbox--touch");
            return builder;
        }
    }
}
