using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class RippleGenerator
    {
        public static TagBuilder GenerateCardRipple()
        {
            var lineRippleBuilder = new TagBuilder("div");
            lineRippleBuilder.AddCssClass("mdc-card__ripple");
            return lineRippleBuilder;
        }

        public static TagBuilder GenerateListItemRipple()
        {
            var rippleBuilder = new TagBuilder("span");
            rippleBuilder.AddCssClass("mdc-list-item__ripple");
            return rippleBuilder;
        }

        public static TagBuilder GenerateDrawerItemRipple()
        {
            var rippleBuilder = new TagBuilder("span");
            rippleBuilder.AddCssClass("mdc-deprecated-list-item__ripple");
            return rippleBuilder;
        }

        public static TagBuilder GenerateSelectRipple()
        {
            var selectRippleBuilder = new TagBuilder("span");
            selectRippleBuilder.AddCssClass("mdc-select__ripple");
            return selectRippleBuilder;
        }

        public static TagBuilder GenerateLineRipple()
        {
            var lineRippleBuilder = new TagBuilder("span");
            lineRippleBuilder.AddCssClass("mdc-line-ripple");
            return lineRippleBuilder;
        }

        public static TagBuilder GenerateButtonRipple()
        {
            var buttonRippleBuilder = new TagBuilder("span");
            buttonRippleBuilder.AddCssClass("mdc-button__ripple");
            return buttonRippleBuilder;
        }

        public static TagBuilder GenerateFabRipple()
        {
            var fabRippleBuilder = new TagBuilder("span");
            fabRippleBuilder.AddCssClass("mdc-fab__ripple");
            return fabRippleBuilder;
        }

        public static TagBuilder GenerateTabRipple()
        {
            var fabRippleBuilder = new TagBuilder("span");
            fabRippleBuilder.AddCssClass("mdc-tab__ripple");
            return fabRippleBuilder;
        }

        public static TagBuilder GenerateCheckboxRipple()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-checkbox__ripple");
            return builder;
        }

        public static TagBuilder GenerateRadioButtonRipple()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-radio__ripple");
            return builder;
        }

        public static TagBuilder GenerateSwitchRipple()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-switch__ripple");
            return builder;
        }
    }
}
