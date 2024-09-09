using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers
{
    [HtmlTargetElement("mdc-radio-input")]
    public class MdcRadioInputTagHelper : TagHelper
    {
        public ModelExpression? For { get; set; }
        public string? Value { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = InputGenerator.GenerateRadioButton(For, Value);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
