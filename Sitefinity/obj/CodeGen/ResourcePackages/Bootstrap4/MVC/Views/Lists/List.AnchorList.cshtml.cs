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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Lists
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
    using Telerik.Sitefinity.Frontend.Lists.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Lists/List.AnchorList.cshtml")]
    public partial class List_AnchorList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_AnchorList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 194), Tuple.Create("\"", 217)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 202), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 202), false)
);

WriteLiteral(">\n\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h1 ");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n            <a");

WriteAttribute("id", Tuple.Create(" id=\"", 393), Tuple.Create("\"", 417)
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 398), Tuple.Create<System.Object, System.Int32>(item.Fields.Id
            
            #line default
            #line hidden
, 398), false)
, Tuple.Create(Tuple.Create("", 413), Tuple.Create("-Top", 413), true)
);

WriteLiteral("\n               ");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
          Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\n               href=\"#");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                 Write(item.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                                  Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n        </h1>\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <ul>\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
             foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
               Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n                    <a ");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                  Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\n                       href=\"#");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                         Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                                              Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n                </li>\n");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h1 ");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\n            id=\"");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
           Write(item.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\n");

WriteLiteral("            ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
       Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\n        </h1>\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"

        foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div ");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
            Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n                <h3 ");

            
            #line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
               Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\n                    id=\"");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                   Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\n");

WriteLiteral("                    ");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
               Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\n                </h3>\n\n                <div ");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                                                                          Write(Html.HtmlSanitize((string)listItem.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n                <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1954), Tuple.Create("\"", 1981)
, Tuple.Create(Tuple.Create("", 1961), Tuple.Create("#", 1961), true)
            
            #line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 1962), Tuple.Create<System.Object, System.Int32>(item.Fields.Id
            
            #line default
            #line hidden
, 1962), false)
, Tuple.Create(Tuple.Create("", 1977), Tuple.Create("-Top", 1977), true)
);

WriteLiteral(">");

            
            #line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
                                             Write(Html.Resource("BackToTop"));

            
            #line default
            #line hidden
WriteLiteral("</a></p>\n            </div>\n");

            
            #line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Lists\List.AnchorList.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n");

        }
    }
}
#pragma warning restore 1591
