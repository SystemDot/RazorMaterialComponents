﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers
{
    [HtmlTargetElement("mdc-switch")]
    public class MdcSwitchTagHelper : TagHelper
    {
        public string? Id { get; set; }
        public MdcElementMode Mode { get; set; }
        public ModelExpression? For { get; set; }
        public bool Disabled { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = SwitchGenerator.GenerateSwitch(Id, Mode, For, Disabled);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
