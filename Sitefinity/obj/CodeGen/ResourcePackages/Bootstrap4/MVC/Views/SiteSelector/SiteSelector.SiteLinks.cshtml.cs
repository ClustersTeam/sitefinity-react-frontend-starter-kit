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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.SiteSelector
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
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
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/SiteSelector/SiteSelector.SiteLinks.cshtm" +
        "l")]
    public partial class SiteSelector_SiteLinks : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector.SiteSelectorViewModel>
    {
        public SiteSelector_SiteLinks()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 252), Tuple.Create("\"", 292)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 260), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 260), false)
, Tuple.Create(Tuple.Create(" ", 275), Tuple.Create("sf-site-selector", 276), true)
);

WriteLiteral(">\n\n    <h3>");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
   Write(Html.Resource("Sites"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n   \n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
      
        string currentSite = string.Empty;
    
            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
     foreach (var site in Model.Sites)
    {
        if (!Model.EachLanguageAsSeparateSite)
        {
            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"selected\"");

WriteLiteral(">");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                      Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode)
            {
            
            #line default
            #line hidden
WriteLiteral("   <li><a>");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                  Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 812), Tuple.Create("\"", 828)
            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 819), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 819), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                   Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
        else if (Model.SiteLanguagesDisplayMode == SiteLanguagesDisplayMode.SiteNamesAndLanguages)
        {
            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"selected\"");

WriteLiteral(">");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                      Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                   Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\n");

            
            #line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode && !SystemManager.IsInlineEditingMode && !SystemManager.IsPreviewMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a>");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                  Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                               Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1386), Tuple.Create("\"", 1402)
            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 1393), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1393), false)
);

WriteLiteral(">");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                   Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n");

            
            #line 45 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
        else
        {
            if(currentSite != site.Name)
            {                                   

            
            #line default
            #line hidden
WriteLiteral("                <li><strong>");

            
            #line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                       Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</strong></li>\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                currentSite = site.Name;
            }

            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"selected\"");

WriteLiteral(">");

            
            #line 57 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                      Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\n");

            
            #line 58 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode && !SystemManager.IsInlineEditingMode && !SystemManager.IsPreviewMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a>");

            
            #line 61 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                  Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n");

            
            #line 62 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {


            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2065), Tuple.Create("\"", 2081)
            
            #line 66 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 2072), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 2072), false)
);

WriteLiteral(">");

            
            #line 66 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                   Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n");

            
            #line 67 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n</div>");

        }
    }
}
#pragma warning restore 1591
