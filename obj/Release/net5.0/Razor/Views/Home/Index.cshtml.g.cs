#pragma checksum "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e8cf1563972fa2e1319ae8dc5a9a5d45ef34f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\_ViewImports.cshtml"
using SudokuGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\_ViewImports.cshtml"
using SudokuGenerator.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e8cf1563972fa2e1319ae8dc5a9a5d45ef34f84", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7915ff9770159215999a5e406a4286aee3139892", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Generator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<!-- Refresh every 30 minutes -->
<meta http-equiv=""refresh"" content=""1800"" />

<!-- Main navbar -->
<nav class=""navbar navbar-dark bg-dark"">
    <span class=""navbar-brand mb-0 h1"">数独 Sudoku Generator</span>

    <ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">
        <li class=""nav-item active"">
            <!-- Open ""help"" modal -->
            <button type=""button"" class=""btn btn-outline-secondary"" data-toggle=""modal"" data-target=""#help""
                style=""width: 97px; border-radius: 0 !important; box-shadow: none; font-size: 20px; background-color: #343a40; border: none"">
                Help
            </button>
        </li>
    </ul>

    <span class=""navbar-text"">
        Randomize and print sudoku puzzles
    </span>
</nav>

<hr>

<!-- Calling controller method to generate new sudoku -->
");
#nullable restore
#line 32 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div style=""position: fixed; top: 107px;"">
        <div style=""display: flex; gap: 4px; font-size: 15px; width: 100%"">
            <button type=""submit"" class=""btn btn-outline-dark""
                style=""width: 97px; border-radius: 0 !important; box-shadow: none"">
                Generate
            </button>
        </div>

        <!-- Choosing desired difficulty and sending it to parameter of controller method -->
        <div style=""position: relative; left: 365px; top: -25px"">
            ");
#nullable restore
#line 44 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
       Write(Html.DropDownList("difficulty", new List<SelectListItem>
            {
                new SelectListItem { Text = "Easy", Value = "Easy"},
                new SelectListItem { Text = "Medium", Value = "Medium"},
                new SelectListItem { Text = "Hard", Value = "Hard"}
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Disable/enable \"Solution\" button and \"Print with solution\" action link -->\r\n");
#nullable restore
#line 55 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
 if (ViewBag.EnableSolution == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""solution-button"" style=""position: fixed; font-size: 15px; left: 830px; top: 107px"">
        <button disabled type=""submit"" class=""btn btn-outline-dark""
            style=""width: 97px; border-radius: 0 !important"">
            Solution
        </button>
    </div>
");
            WriteLiteral("    <div style=\"position: fixed; left: 1137px; top: 627px; font-size: 18px \">Print with solution</div>\r\n");
#nullable restore
#line 65 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
}
else if (ViewBag.EnableSolution == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""solution-button"" style=""position: fixed; font-size: 15px; left: 830px; top: 107px "">
        <button data-toggle=""button"" onclick=hideSolution() type=""submit"" class=""btn btn-outline-dark""
            style=""width: 97px; border-radius: 0 !important; box-shadow: none"">
            Solution
        </button>
    </div>
");
            WriteLiteral("    <div style=\"position: fixed; left: 1137px; top: 627px; font-size: 18px \">");
#nullable restore
#line 75 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                                                                        Write(Html.ActionLink("Print with solution", "PrintSolution"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 76 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"position: fixed; left: 625px; top: 627px; font-size: 18px\">");
#nullable restore
#line 78 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                                                                  Write(Html.ActionLink("Print", "PrintSudoku"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<!-- Boostrap modal with hints how to use the application -->
<div class=""modal fade"" id=""help"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Help</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <ul>
                    <li>Use ""Generate"" button to create a new sudoku puzzle</li>
                    <li>Choose desired difficulty from a drop down list</li>
                    <li>Use ""Solution"" button to show/hide solution for the current sudoku puzzle</li>
                    <li>Use ""Print"" link to print the current sudoku puzzle</li>
                    <li>Use ""Print with solution"" link to prin");
            WriteLiteral(@"t both the current sudoku and it's solution</li>
                    <li>The ""Solution"" button doesn't have to be pressed in order to include solution</li>
                </ul>
            </div>
        </div>
    </div>
</div>

<!-- Generated sudoku -->
<div class=""grid-container"" style=""position: fixed; top: 155px; font-size: 20px"">

");
#nullable restore
#line 107 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
      var nextYCell = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
      var nextXCell = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
     for (var k = 0; k < 9; k++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <table>\r\n");
#nullable restore
#line 114 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                 for (var j = 0 + nextYCell; j < 3 + nextYCell; j++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 117 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                         for (var i = 0 + nextXCell; i < 3 + nextXCell; i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                             if (ViewBag.Value[j, i] == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color: white\">");
#nullable restore
#line 121 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                                                    Write(ViewBag.Value[j, i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 122 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 125 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                               Write(ViewBag.Value[j, i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 126 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 129 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 132 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
        nextXCell += 3;
        if (nextXCell > 6)
        {
            nextXCell = 0;
            nextYCell += 3;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<!-- Empty solution -->\r\n<div class=\"grid-container\" style=\"position: fixed; top: 155px; left: 830px\">\r\n");
#nullable restore
#line 143 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
     for (var i = 0; i < 9; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div>
            <table>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </div>
");
#nullable restore
#line 164 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<!-- Sudoku solution -->\r\n<div id=\"solutionTable\" class=\"grid-container\" style=\"position: fixed; top: 155px; left: 830px; display: none; font-size: 20px\">\r\n\r\n");
#nullable restore
#line 170 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
      nextYCell = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
      nextXCell = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 173 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
     for (var k = 0; k < 9; k++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <table>\r\n");
#nullable restore
#line 177 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                 for (var j = 0 + nextYCell; j < 3 + nextYCell; j++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 180 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                         for (var i = 0 + nextXCell; i < 3 + nextXCell; i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 182 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                             if (ViewBag.Solution[j, i] == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color: white\">");
#nullable restore
#line 184 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                                                    Write(ViewBag.Solution[j, i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 185 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 188 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                               Write(ViewBag.Solution[j, i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 189 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 192 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 195 "C:\Users\Dell Latitude\Desktop\rozne\materialy put\C#\SudokuGenerator\SudokuGenerator\Views\Home\Index.cshtml"
        nextXCell += 3;
        if (nextXCell > 6)
        {
            nextXCell = 0;
            nextYCell += 3;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<!-- Footer with link to GitHub -->
<nav class=""navbar navbar-dark bg-dark"" style=""position: fixed; left: 0; bottom: 0; width: 135px"">
    <span class=""navbar-brand mb-0 h1"">
        <a href=""https://github.com/Pu-ck"" type=""button"" class=""btn btn-outline-secondary""
            style=""width: 97px; border-radius: 0 !important; box-shadow: none; font-size: 20px; background-color: #343a40; border: none"">
            GitHub
        </a>
    </span>
</nav>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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