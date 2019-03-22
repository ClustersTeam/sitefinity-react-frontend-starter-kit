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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using System;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/DocumentsList/List.DocumentsTable.cshtml")]
    public partial class List_DocumentsTable : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentsListViewModel>
    {
        public List_DocumentsTable()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 225), Tuple.Create("\"", 248)
            
            #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 233), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 233), false)
);

WriteLiteral(">\n\n    <div");

WriteLiteral(" class=\"sf-document-list sf-document-list--table\"");

WriteLiteral(">\n\n        <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\n            <thead>\n                <tr>\n                    <td><strong>");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                           Write(Html.Resource("Title"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\n                    <td><strong>");

            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                           Write(Html.Resource("Type"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\n                    <td><strong>");

            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                           Write(Html.Resource("Size"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\n                    <td></td>\n                </tr>\n            </" +
"thead>\n");

            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
             foreach (var item in Model.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\n                    <td>\n                        <i");

WriteLiteral(" class=\"icon-file icon-txt icon-sm\"");

WriteLiteral(">\n                            <span");

WriteAttribute("class", Tuple.Create(" class=\"", 867), Tuple.Create("\"", 926)
, Tuple.Create(Tuple.Create("", 875), Tuple.Create("icon-txt-", 875), true)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 884), Tuple.Create<System.Object, System.Int32>(((DocumentItemViewModel)item).Extension
            
            #line default
            #line hidden
, 884), false)
);

WriteLiteral(">");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                                                                          Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </i> \n                        <a");

WriteLiteral(" class=\"sf-title\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1051), Tuple.Create("\"", 1165)
            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 1058), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix)
            
            #line default
            #line hidden
, 1058), false)
);

WriteLiteral(">\n");

WriteLiteral("                            ");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                       Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\n                        </a>\n                    </td>\n                    <td>\n" +
"");

WriteLiteral("                        ");

            
            #line 32 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                    Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("\n                    </td>\n                    <td>\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                    Write(Math.Ceiling((double)item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral("\n                    </td>\n                    <td>\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1576), Tuple.Create("\"", 1604)
            
            #line 38 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 1583), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1583), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Download</a>\n                    </td>\n                </tr>\n");

            
            #line 41 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\n\n    </div>\n\n</div>\n\n");

            
            #line 48 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 55 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
         
}

            
            #line default
            #line hidden
WriteLiteral("\n\n");

        }
    }
}
#pragma warning restore 1591
