#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.NavigationField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 3 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/NavigationField/Read.Default.cshtml")]
    public partial class Read_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.NavigationField.NavigationFieldViewModel>
    {
        public Read_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 9 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
  
    var totalPages = Model.Pages.Count();

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 309), Tuple.Create("\"", 343)
            
            #line 13 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 317), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 317), false)
, Tuple.Create(Tuple.Create(" ", 332), Tuple.Create("form-group", 333), true)
);

WriteLiteral(" data-sf-role=\"navigation-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"step-of-resources\"");

WriteAttribute("value", Tuple.Create(" value=\"", 445), Tuple.Create("\"", 477)
            
            #line 14 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 453), Tuple.Create<System.Object, System.Int32>(Html.Resource("StepOf")
            
            #line default
            #line hidden
, 453), false)
);

WriteLiteral(" />\n    <ol");

WriteLiteral(" data-sf-role=\"sr-progressbar\"");

WriteLiteral(" class=\"sf-FormNav\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuemin=\"1\"");

WriteAttribute("aria-valuemax", Tuple.Create(" aria-valuemax=\"", 588), Tuple.Create("\"", 615)
            
            #line 15 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
                                           , Tuple.Create(Tuple.Create("", 604), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 604), false)
);

WriteLiteral(" aria-valuenow=\"1\"");

WriteAttribute("aria-valuetext", Tuple.Create(" aria-valuetext=\"", 634), Tuple.Create("\"", 672)
, Tuple.Create(Tuple.Create("", 651), Tuple.Create("Step", 651), true)
, Tuple.Create(Tuple.Create(" ", 655), Tuple.Create("1", 656), true)
, Tuple.Create(Tuple.Create(" ", 657), Tuple.Create("of", 658), true)
            
            #line 15 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create(" ", 660), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 661), false)
);

WriteLiteral(">\n");

            
            #line 16 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
      
        var pageCounter = 0;
        foreach (var page in Model.Pages)
        {
            pageCounter++;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"d-inline-flex align-items-center\"");

WriteLiteral("  data-sf-navigation-index=\"");

            
            #line 21 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
                                                                               Write(page.Index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\n               <span");

WriteLiteral(" class=\"sf-FormNav-page d-inline-flex align-items-center justify-content-center\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-FormNav-page-number\"");

WriteLiteral(">");

            
            #line 23 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
                                                    Write(pageCounter);

            
            #line default
            #line hidden
WriteLiteral(" </span>\n               </span>\n               <span");

WriteLiteral(" data-sf-page-title=\"");

            
            #line 25 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
                                    Write(page.Title);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 25 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
                                                 Write(Html.HtmlSanitize(page.Title));

            
            #line default
            #line hidden
WriteLiteral("</span>\n            </li>\n");

            
            #line 27 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
        }
    
            
            #line default
            #line hidden
WriteLiteral("\n    </ol>\n</div>\n\n");

            
            #line 32 "..\..MVC\Views\NavigationField\Read.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/NavigationField/navigation-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591