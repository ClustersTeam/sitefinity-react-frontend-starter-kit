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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.FlatTaxonomy
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/FlatTaxonomy/FlatTaxonomy.CloudList.cshtml")]
    public partial class FlatTaxonomy_CloudList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public FlatTaxonomy_CloudList()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 79), Tuple.Create("\"", 124)
            
            #line 3 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
, Tuple.Create(Tuple.Create("", 87), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 87), false)
, Tuple.Create(Tuple.Create(" ", 102), Tuple.Create("sf-Tags", 103), true)
, Tuple.Create(Tuple.Create(" ", 110), Tuple.Create("list-unstyled", 111), true)
);

WriteLiteral(">\n");

            
            #line 4 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
     foreach (var taxa in Model.Taxa)
    {
        var cloudSizeClass = "sf-Tags-size" + @taxa.CloudSize;
    
        
            
            #line default
            #line hidden
WriteLiteral("<li>\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 266), Tuple.Create("\"", 282)
            
            #line 9 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
, Tuple.Create(Tuple.Create("", 273), Tuple.Create<System.Object, System.Int32>(taxa.Url
            
            #line default
            #line hidden
, 273), false)
);

WriteAttribute("class", Tuple.Create(" class=\"", 283), Tuple.Create("\"", 306)
            
            #line 9 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
, Tuple.Create(Tuple.Create("", 291), Tuple.Create<System.Object, System.Int32>(cloudSizeClass
            
            #line default
            #line hidden
, 291), false)
);

WriteLiteral(">");

            
            #line 9 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                                                   Write(taxa.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n            <span");

WriteLiteral(" class=\"small text-muted\"");

WriteLiteral(">\n");

            
            #line 11 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                
            
            #line default
            #line hidden
            
            #line 11 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                 if (Model.ShowItemCount)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("(");

            
            #line 13 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                  Write(taxa.Count);

            
            #line default
            #line hidden
WriteLiteral(")\n");

            
            #line 14 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </span>\n        </li>\n");

            
            #line 17 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>");

        }
    }
}
#pragma warning restore 1591
