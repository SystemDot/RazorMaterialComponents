using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers
{
    [HtmlTargetElement("mdc-switch-off-svg")]
    public class MdcSwitchOffSvgTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = SvgGenerator.GenerateSwitchOff();
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
