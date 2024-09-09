using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers
{
    [HtmlTargetElement("mdc-radio")]
    public class MdcRadioTagHelper : TagHelper
    {
        public string? Id { get; set; }
        public MdcElementMode Mode { get; set; }
        public ModelExpression? For { get; set; }
        public string? Value { get; set; }
        public bool Touch { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = RadioButtonGenerator.GenerateRadioButton(Id, Mode, For, Value, Touch);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
