#pragma checksum "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c91202012731fd905bfbf336ca77968ef6d8e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.pages_search_assignatures), @"mvc.1.0.razor-page", @"/pages/search/assignatures.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c91202012731fd905bfbf336ca77968ef6d8e7", @"/pages/search/assignatures.cshtml")]
    public class pages_search_assignatures : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
  
  Layout = "../shared/_AdminMenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"">
  <h1 class=""display-3"">Assignatures</h1>
    <table class=""table"">
      <thead class=""thead-inverse"">
        <tr>
          <th>Hours</th>
          <th>Group</th>
          <th>Subject</th>
        </tr>
      </thead>
      
      <tbody>
");
#nullable restore
#line 21 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
       foreach(var teacher in Model.Teachers)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <th></th>\r\n          <th></th>\r\n          <th class=\"bg-primary\">Teacher: ");
#nullable restore
#line 26 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
                                     Write(teacher.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
                                                        Write(teacher.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
                                                                            Write(teacher.FirstSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
                                                                                                  Write(teacher.SecondSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
       foreach(var assignature in Model.GetTeacherAssignatures(teacher.IdTeacher))
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 31 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
          Write(Model.GetSubject(assignature).TheoreticalHours + Model.GetSubject(assignature).PracticalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 32 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
         Write(Model.GetGroup(assignature).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 33 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
         Write(Model.GetSubject(assignature).Name.PadLeft(60, ' '));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\assignatures.cshtml"
       
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.AssignaturesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.AssignaturesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.AssignaturesModel>)PageContext?.ViewData;
        public WebApp.Pages.AssignaturesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
