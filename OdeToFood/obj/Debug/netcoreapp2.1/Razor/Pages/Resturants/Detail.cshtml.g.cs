#pragma checksum "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db65b6ed9d13af99aaf470b992c9c5bb9bc952eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Resturants.Pages_Resturants_Detail), @"mvc.1.0.razor-page", @"/Pages/Resturants/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Resturants/Detail.cshtml", typeof(OdeToFood.Pages.Resturants.Pages_Resturants_Detail), @"{resturantId:int}")]
namespace OdeToFood.Pages.Resturants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{resturantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db65b6ed9d13af99aaf470b992c9c5bb9bc952eb", @"/Pages/Resturants/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd7a9498867045fbda097e3208cbd1c6a5a509f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Resturants_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml"
  
    ViewData["Titel"] = "Detail";

#line default
#line hidden
            BeginContext(118, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(125, 20, false);
#line 8 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml"
Write(Model.Resturant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(145, 22, true);
            WriteLiteral("</h2>\r\n<div>\r\n    Id: ");
            EndContext();
            BeginContext(168, 18, false);
#line 10 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml"
   Write(Model.Resturant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(186, 32, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Location : ");
            EndContext();
            BeginContext(219, 24, false);
#line 13 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml"
          Write(Model.Resturant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(243, 32, true);
            WriteLiteral(" \r\n</div>\r\n<div>\r\n    Cuisine : ");
            EndContext();
            BeginContext(276, 23, false);
#line 16 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml"
         Write(Model.Resturant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(299, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 18 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml"
 if (Model.Message != null)
{

#line default
#line hidden
            BeginContext(341, 34, true);
            WriteLiteral("    <div class=\"alert alert-info\">");
            EndContext();
            BeginContext(376, 13, false);
#line 20 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml"
                             Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(389, 9, true);
            WriteLiteral("</div> \r\n");
            EndContext();
#line 21 "C:\Users\mibra\source\repos\OdeToFood\OdeToFood\Pages\Resturants\Detail.cshtml"
}

#line default
#line hidden
            BeginContext(401, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c087ef0b3914ff09cf6b399ff3d39b4", async() => {
                BeginContext(446, 14, true);
                WriteLiteral("All Resturants");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Resturants.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Resturants.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Resturants.DetailModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Resturants.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
