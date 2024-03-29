#pragma checksum "E:\Projects\Pos\Views\Shared\_Culture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca47299a701109f8f233ed1e687abff9f46199e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Culture), @"mvc.1.0.view", @"/Views/Shared/_Culture.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca47299a701109f8f233ed1e687abff9f46199e", @"/Views/Shared/_Culture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743712596874420410edbf14c56f7d7d037dbe42", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Culture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Projects\Pos\Views\Shared\_Culture.cshtml"
      
       var Culture=Context.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>();
       var CultureList=LocalizationOptions.Value.SupportedCultures.Select(x=>new SelectListItem{Value=x.Name,Text=x.Name}).ToList();
       var returnurl=string.IsNullOrWhiteSpace(Context.Request.Path)? "~/" :$"{Context.Request.Path.Value}{Context.Request.QueryString}";  

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <input hidden id=\"langs\"");
            BeginWriteAttribute("value", " value=\"", 637, "\"", 683, 1);
#nullable restore
#line 12 "E:\Projects\Pos\Views\Shared\_Culture.cshtml"
WriteAttributeValue("", 645, Culture.RequestCulture.UICulture.Name, 645, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 13 "E:\Projects\Pos\Views\Shared\_Culture.cshtml"
         if (Culture.RequestCulture.UICulture.Name =="en")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""Langselect mx-0 mt-1"">
            <div class=""myselect"">
                <div class=""selectedlan"">
                    <img class=""langselect"" width=""25px"" title=""English"" src=""/imgs/en.png"" /> 
                    <span class=""langName"" > English </span> 
                </div>
                <div class=""langHover"" >
                    <span class=""myselect-option"" title=""Change Language"">
                        <a");
            BeginWriteAttribute("href", " href=\'", 1210, "\'", 1303, 1);
#nullable restore
#line 23 "E:\Projects\Pos\Views\Shared\_Culture.cshtml"
WriteAttributeValue("", 1217, Url.Action("CultureMangement", "Home", new  {Culture = "ar", returnurl = @returnurl}), 1217, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" >
                        <img class=""langopt"" width=""23px"" title=""Arabic""  src=""/imgs/ar.png"" /> 
                        <span class=""langName"" >Arabic</span> 
                        </a>
                    </span>
                </div>
            </div>
        </div> 
");
#nullable restore
#line 31 "E:\Projects\Pos\Views\Shared\_Culture.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""Langselect mx-0 mt-1"">
            <div class=""myselect"">
                <div class=""selectedlan"">
                    <img class=""langselect""  width=""25px"" title=""عربي"" src=""/imgs/ar.png"" /> 
                    <span class=""langName"" >العربية</span>
                </div>
                <div class=""langHover"" >
                    <span class=""myselect-option"" title=""Change Language"">
                        <a");
            BeginWriteAttribute("href", " href=\'", 2080, "\'", 2173, 1);
#nullable restore
#line 42 "E:\Projects\Pos\Views\Shared\_Culture.cshtml"
WriteAttributeValue("", 2087, Url.Action("CultureMangement", "Home", new  {Culture = "en", returnurl = @returnurl}), 2087, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" >
                        <img class=""langopt"" width=""23px"" title=""الانجليزية"" src=""/imgs/en.png"" /> 
                        <span class=""langName"" >الانجليزية</span> 
                        </a>
                    </span>
                </div>
            </div>
        </div>
");
#nullable restore
#line 50 "E:\Projects\Pos\Views\Shared\_Culture.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.RequestLocalizationOptions> LocalizationOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
