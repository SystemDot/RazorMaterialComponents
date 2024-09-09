using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class RadioButtonGenerator
    {
        public static TagBuilder GenerateRadioButton(string? id, MdcElementMode mode, ModelExpression? @for, string? value, bool touch)
        {
            if (mode == MdcElementMode.Exploded)
            {
                return GenerateRadioButtonExploded(id, touch);
            }
            else
            {
                return GenerateRadioButtonContained(id, @for, value, touch);
            }
        }

        private static TagBuilder GenerateRadioButtonContained(string? id, ModelExpression? @for, string? value, bool touch)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            TagBuilder containerBuilder = GenerateRadioButtonContainer(touch);
            HtmlContentBuilder containerContent = new HtmlContentBuilder();
            
            TagBuilder inputBuilder = InputGenerator.GenerateRadioButton(@for, value);
            inputBuilder.Attributes.Add("id", id);
            containerContent.AppendLine(inputBuilder);

            TagBuilder backgroundBuilder = GenerateRadioButtonBackground();
            HtmlContentBuilder backgroundContent = new HtmlContentBuilder();

            backgroundContent.AppendLine(GenerateRadioButtonOuterCircle());
            backgroundContent.AppendLine(GenerateRadioButtonInnerCircle());

            backgroundBuilder.InnerHtml.SetHtmlContent(backgroundContent);

            containerContent.AppendLine(backgroundBuilder);
            containerContent.AppendLine(RippleGenerator.GenerateRadioButtonRipple());

            containerBuilder.InnerHtml.SetHtmlContent(containerContent);

            return containerBuilder;
        }

        private static TagBuilder GenerateRadioButtonExploded(string? id, bool touch)
        {
            TagBuilder builder = GenerateRadioButtonContainer(touch);

            if (id is not null)
            {
                builder.Attributes.Add("id", id);
            }

            return builder;
        }

        public static TagBuilder GenerateRadioButtonBackground()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-radio__background");
            return builder;
        }

        public static TagBuilder GenerateRadioButtonOuterCircle()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-radio__outer-circle");
            return builder;
        }
        public static TagBuilder GenerateRadioButtonInnerCircle()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-radio__inner-circle");
            return builder;
        }

        private static TagBuilder GenerateRadioButtonContainer(bool touch)
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-radio");
            builder.AddCssClass("mdc-radio--touch");
            return builder;
        }
    }
}
