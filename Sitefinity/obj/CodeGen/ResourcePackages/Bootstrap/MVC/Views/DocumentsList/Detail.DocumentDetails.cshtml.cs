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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.DocumentsList
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/DocumentsList/Detail.DocumentDetails.cshtm" +
        "l")]
    public partial class Detail_DocumentDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentDetailsViewModel>
    {
        public Detail_DocumentDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 190), Tuple.Create("\"", 213)
            
            #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 198), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 198), false)
);

WriteLiteral(">\n\n    <h1>\n");

WriteLiteral("        ");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\n    </h1>\n\n    <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n\n    <div>\n");

WriteLiteral("        ");

            
            #line 19 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n\n    <div>\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 565), Tuple.Create("\"", 599)
            
            #line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 572), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.MediaUrl
            
            #line default
            #line hidden
, 572), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Download</a>\n        <span");

WriteLiteral(" class=\"sf-document-extension\"");

WriteLiteral(">(");

            
            #line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                        Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\n        <span");

WriteLiteral(" class=\"sf-document-size\"");

WriteLiteral(">");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                   Write(Math.Ceiling((double)Model.Item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral("</span>\n    </div>    \n</div>");

        }
    }
}
#pragma warning restore 1591
