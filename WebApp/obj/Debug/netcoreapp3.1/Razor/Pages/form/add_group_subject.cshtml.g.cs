#pragma checksum "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d30cb6d2c35727b1d840bac41cc293148d158c74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_form_add_group_subject), @"mvc.1.0.razor-page", @"/Pages/form/add_group_subject.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30cb6d2c35727b1d840bac41cc293148d158c74", @"/Pages/form/add_group_subject.cshtml")]
    public class Pages_form_add_group_subject : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
  
  Layout = "../shared/_AdminMenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"">
  <h1 class=""display-3"">Groups's Subjects</h1>
    <table class=""table"">
      <thead class=""thead-inverse"">
        <tr>
          <th>Total Hours</th>
          <th>Practical Hours</th>
          <th>Theoretical Hours</th>
          <th>Subject</th>
        </tr>
      </thead>
      
      <tbody>
");
#nullable restore
#line 23 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
       foreach(var group in Model.Groups)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <th></th>\r\n          <th></th>\r\n          <th></th>\r\n");
#nullable restore
#line 29 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
           if(Model.LessThanMaxGroupSubjects(group))
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <th class=\"bg-primary\">Group: ");
#nullable restore
#line 31 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
                                    Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 32 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
          }
          else
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th class=\"bg-success\">Group: ");
#nullable restore
#line 35 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
                                     Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 36 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
       foreach(var groupSubject in Model.GetGroupSubjects(group.IdGroup))
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 41 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
          Write(Model.GetSubject(groupSubject).PracticalHours + Model.GetSubject(groupSubject).TheoreticalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 42 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
         Write(Model.GetSubject(groupSubject).PracticalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 43 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
         Write(Model.GetSubject(groupSubject).TheoreticalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 44 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
         Write(Model.GetSubject(groupSubject).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
       
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      </tbody>
    </table>
</div>
<br><br>

<div class=""jumbotron"">
  <h1 class=""display-3"">Add New Group Subject</h1>
  <p class=""lead"">Select the group and the new subject. Only appears the valid groups and if your selection
    already exists then it won't be changes by submiting
  </p>
  <hr/>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d30cb6d2c35727b1d840bac41cc293148d158c749088", async() => {
                WriteLiteral("\r\n\r\n  <!-- Selection -->\r\n  <div class=\"form-row\">\r\n\r\n    <!-- Subject Name -->\r\n    <div class=\"col-md-4 mb-3 pull-4\">\r\n      <label for=\"exampleSelect1\">Select the subject</label>\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d30cb6d2c35727b1d840bac41cc293148d158c749553", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
         foreach (var item in Model.Subjects)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d30cb6d2c35727b1d840bac41cc293148d158c7410158", async() => {
#nullable restore
#line 71 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
               WriteLiteral(item.IdSubject);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 68 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubjectID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    <!-- Group Name -->\r\n    <div class=\"col-md-4 mb-3 pull-4\">\r\n      <label for=\"exampleSelect1\">Select the group</label>\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d30cb6d2c35727b1d840bac41cc293148d158c7414086", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
         foreach (var item in Model.Groups)
        {
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
           if(Model.LessThanMaxGroupSubjects(item))
          {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d30cb6d2c35727b1d840bac41cc293148d158c7414996", async() => {
#nullable restore
#line 84 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
               WriteLiteral(item.IdGroup);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
           
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 79 "C:\Users\a1730\Desktop\CETI\VII_Semester\Advanced_Programming\III_Partial\Final_Project\AP_FinalProject\WebApp\Pages\form\add_group_subject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GroupID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>

  </div>

  <!-- Agreenment -->
  <div class=""form-group"">
    <div class=""custom-control custom-checkbox"">
      <input type=""checkbox"" class=""custom-control-input"" id=""invalidCheck33"" required>
      <label class=""custom-control-label"" for=""invalidCheck33"">Agree to terms and conditions</label>
    </div>
  </div>

  <button class=""btn btn-primary"" type=""submit"">Submit form</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.AddGroupSubjectModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.AddGroupSubjectModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.AddGroupSubjectModel>)PageContext?.ViewData;
        public WebApp.Pages.AddGroupSubjectModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591