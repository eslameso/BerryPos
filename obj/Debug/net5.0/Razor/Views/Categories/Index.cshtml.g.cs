#pragma checksum "E:\Projects\Pos\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe9158780e9652bf8e425a0dc96792d76e7f18b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9158780e9652bf8e425a0dc96792d76e7f18b3", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743712596874420410edbf14c56f7d7d037dbe42", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomDeleteSwalServerSide.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ServerSideDataTable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Projects\Pos\Views\Categories\Index.cshtml"
  
    ViewData["Title"]="Categories";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Categories</h2>

<button id=""CreateCategory_btn"" class="" btn btn-primary mt-2"">Create new Category</button>
<br />
<br />
<table style=""width:100%"" class=""table table-striped table-bordered"" style=""width:100%"" id=""CategoriesTable"">
    <thead>
        <tr>
            
            <th>Category Name</th>
            <th>Description</th>

            <th></th>
        </tr>
    </thead>
    <tbody></tbody>
</table>



<div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""ItemsModal"">
    <div class=""modal-dialog"" role=""document"" id=""modalcontent"">

    </div>
</div>





");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9158780e9652bf8e425a0dc96792d76e7f18b34789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9158780e9652bf8e425a0dc96792d76e7f18b35889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<script>
   $(document).ready(function(){
       let dataTableColumns = [{ data: ""name"" },{data :""description""},

            {
                data: ""id"", orderable: false, render: function (result, x, y) {


                    return `<button class=""btn default btn-editable edit-Item btn-primary"" data-id=""${result}""> <i class=""fa fa-pencil""> </i> Edit </button>
                            <button class=""btn red btn delete-Item btn-danger"" data-id=""${result}""> <i class=""glyphicon glyphicon-remove""> </i> Delete </button>`;

                }
            }];

            globaltable = tablePlugin(""#CategoriesTable"", ""/Categories/GetListOfCategories"", dataTableColumns,localizedData);
         });
       
       $('#CategoriesTable').on(""click"",'.delete-Item',function(){
           var dataId = $(this).attr(""data-id"");
         CustomDelete(""/Categories/Delete"",dataId);
       });

       $('#CategoriesTable').on(""click"",'.edit-Item',function(){
           var dataId = $(this).attr(""dat");
                WriteLiteral(@"a-id"");
          $.ajax({
              url:""/Categories/Edit/""+dataId,
              method:""Get"",
              success:function(result)
              {
                  $('#modalcontent').html(result);
                  $('#ItemsModal').modal(""show"");
                 var form = $(""form"");
                        form.removeData('validator');
                        form.removeData('unobtrusiveValidation');
                        $.validator.unobtrusive.parse(form);
              }

          });
       });

       $('#CreateCategory_btn').click(function(){
          $.ajax({
              url:""/Categories/Create"",
              method:""Get"",
              success:function(result)
              {
                  $('#modalcontent').html(result);
                  $('#ItemsModal').modal(""show"");
                 var form = $(""form"");
                        form.removeData('validator');
                        form.removeData('unobtrusiveValidation');
                        ");
                WriteLiteral(@"$.validator.unobtrusive.parse(form);
              }

          });
       });

    function CreateSuccess()
    {
     $('#ItemsModal').modal(""hide"");
    swal(""Successfuly Create Branch "");
    globaltable.ajax.reload();
   
    }

    function CreateFailure()
    {
     $('#ItemsModal').modal(""hide"");
    swal(""Faild To Create Branch "");
    
   
    }


     function EditSuccess()
    {
     $('#ItemsModal').modal(""hide"");
    swal(""Successfuly Edit Branch "");
    globaltable.ajax.reload();
   
    }

    function EditFailure()
    {
     $('#ItemsModal').modal(""hide"");
    swal(""Faild To Edit Branch "");
    
    }



        
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
