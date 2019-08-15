#pragma checksum "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5345f703595b600ff980be75a6028ca78a07bef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/_ViewImports.cshtml"
using LostInTheWoods;

#line default
#line hidden
#line 2 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/_ViewImports.cshtml"
using LostInTheWoods.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5345f703595b600ff980be75a6028ca78a07bef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9ba960125634dc0fdf3d0e3fb0f83ed2ab9064", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dictionary<string, object>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(88, 321, true);
            WriteLiteral(@"
<div class=""text-left"">
    <h1 class=""display-4 d-inline text-success"">Lost In The Woods</h1>
    <p class=""d-inline"">List of local hiking trails</p>
</div>
<table class=""table table-hover"">
    <thead>
        <th>Trail Name</th>
        <th>Trail Length</th>
        <th>Elevation Change</th>
    </thead>
");
            EndContext();
#line 17 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml"
     foreach(var trail in Model)
    {

#line default
#line hidden
            BeginContext(450, 28, true);
            WriteLiteral("    <tbody>\r\n        <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 478, "\'", 504, 2);
            WriteAttributeValue("", 485, "trails/", 485, 7, true);
#line 20 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml"
WriteAttributeValue("", 492, trail["id"], 492, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(505, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(507, 11, false);
#line 20 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml"
                                      Write(trail["id"]);

#line default
#line hidden
            EndContext();
            BeginContext(518, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(520, 13, false);
#line 20 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml"
                                                   Write(trail["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(533, 23, true);
            WriteLiteral("</a></td>\r\n        <td>");
            EndContext();
            BeginContext(557, 15, false);
#line 21 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml"
       Write(trail["length"]);

#line default
#line hidden
            EndContext();
            BeginContext(572, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(592, 18, false);
#line 22 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml"
       Write(trail["elevation"]);

#line default
#line hidden
            EndContext();
            BeginContext(610, 21, true);
            WriteLiteral("</td>\r\n    </tbody>\r\n");
            EndContext();
#line 24 "/Users/angeloliwanag/Documents/CodingDojo/C#/ORM/LostInTheWoods/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(638, 114, true);
            WriteLiteral("\r\n</table>\r\n<a href=\"NewTrail\">\r\n    <button class=\"btn btn-outline-success btn-sm\">Add a new trail</button>\r\n</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dictionary<string, object>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
