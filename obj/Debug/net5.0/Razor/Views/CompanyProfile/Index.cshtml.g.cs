#pragma checksum "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5bdf75975ca1ef762090b95f672d72477aca6c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompanyProfile_Index), @"mvc.1.0.view", @"/Views/CompanyProfile/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\Pos\Views\_ViewImports.cshtml"
using Pos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Pos\Views\_ViewImports.cshtml"
using Pos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\Pos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5bdf75975ca1ef762090b95f672d72477aca6c8", @"/Views/CompanyProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743712596874420410edbf14c56f7d7d037dbe42", @"/Views/_ViewImports.cshtml")]
    public class Views_CompanyProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "companyprofile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
  
    ViewData["Title"]="Company Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Company Profile</h3>\r\n<br>\r\n");
#nullable restore
#line 7 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
 if (Model !=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card \">\r\n  <div class=\"card-header \">\r\n     <h4 class=\"text-primary\"> Comapny Name : ");
#nullable restore
#line 11 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
                                          Write(string.IsNullOrEmpty(Model.CompanyName) ? "" : @Model.CompanyName );

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n  </div>\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-text text-primary\">Comapany Logo : </h5>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 407, "\"", 440, 2);
            WriteAttributeValue("", 413, "/Uploads/", 413, 9, true);
#nullable restore
#line 15 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
WriteAttributeValue("", 422, Model.CompanyLogo, 422, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100px; height:70px;\" > \r\n    <h5 class=\"card-text text-primary\">Comapany Owner Name : </h5> <h5> ");
#nullable restore
#line 16 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
                                                                    Write(Model.OwnerName == null ? "" : @Model.OwnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n    <h5 class=\"card-text text-primary\">Comapany Type : </h5> <h5> ");
#nullable restore
#line 17 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
                                                              Write(Model.ComapanyType == null ? "" : @Model.ComapanyType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n     <h5 class=\"card-text text-primary\">Comapany Description : </h5> <h5> ");
#nullable restore
#line 18 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
                                                                      Write(Model.CompanyDescription == null ? "" : @Model.CompanyDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n    <h5 class=\"card-text text-primary\"> Notes : </h5> <h5> ");
#nullable restore
#line 19 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
                                                       Write(Model.Notes == null ? "" : @Model.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n   </div>\r\n  <div class=\"card-footer text-muted\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5bdf75975ca1ef762090b95f672d72477aca6c87297", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   \r\n  </div>\r\n</div>\r\n");
#nullable restore
#line 26 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <div class=""card "">
  <div class=""card-header"">
     <h4 class=""text-primary""> Comapny Name : No Name</h4>
  </div>
  <div class=""card-body"">
    <h5 class=""card-text"">There Is No Data About Your Company</h5>
   </div>
  <div class=""card-footer text-muted"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5bdf75975ca1ef762090b95f672d72477aca6c810235", async() => {
                WriteLiteral("Add Data");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   \r\n  </div>\r\n</div>   \r\n");
#nullable restore
#line 41 "E:\Projects\Pos\Views\CompanyProfile\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
