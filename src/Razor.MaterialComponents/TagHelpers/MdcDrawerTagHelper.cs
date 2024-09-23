﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers
{
    [HtmlTargetElement("mdc-drawer")]
    public class MdcDrawerTagHelper : TagHelper
    {
        public string Id { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = DrawerGenerator.GenerateDrawer(Id);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}