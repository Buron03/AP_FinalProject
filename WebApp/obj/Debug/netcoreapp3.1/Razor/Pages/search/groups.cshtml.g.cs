#pragma checksum "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0e1b9d8061386c60c63c22cb921c81d569989b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.pages_search_groups), @"mvc.1.0.razor-page", @"/pages/search/groups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e1b9d8061386c60c63c22cb921c81d569989b8", @"/pages/search/groups.cshtml")]
    public class pages_search_groups : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
  
  Layout = "../shared/_AdminMenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"">
  <h1 class=""display-3"">Groups</h1>
  <table class=""table"">
    <thead class=""thead-inverse"">
      <tr>
        <th>Status</th>
        <th>Total Subjects</th>
        <th>Total Teachers</th>
        <th>Total Hours</th>
        <th>Close Date</th>
        <th>Start Date</th>
        <th>Kind</th>
        <th>Name</th>
      </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
     foreach(var group in Model.Groups)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n");
#nullable restore
#line 28 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
         if(Model.GetGroupStatus(group.IdGroup))
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class=\"bg-success\">Complete</td>\r\n");
#nullable restore
#line 31 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
          }
          else
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class=\"bg-warning\">Incomplete</td>\r\n");
#nullable restore
#line 35 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 36 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
       Write(Model.GetTotalSubjectsOfGroup(group.IdGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
       Write(Model.GetTotalTeachersOfGroup(group.IdGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
       Write(Model.GetTotalHoursGroup(group.IdGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
       Write(group.CloseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 40 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
       Write(group.StartDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 41 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
       Write(Model.GetPeriodKind(group.IdPeriodKind).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 42 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
       Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      </tr>\r\n");
#nullable restore
#line 44 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\search\groups.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.GroupsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.GroupsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.GroupsModel>)PageContext?.ViewData;
        public WebApp.Pages.GroupsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591