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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.ImageGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/ImageGallery/List.ImageGallery.cshtml")]
    public partial class List_ImageGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_ImageGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\n  <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 352), Tuple.Create("\"", 407)
, Tuple.Create(Tuple.Create("", 360), Tuple.Create("sf-Gallery-thumbs", 360), true)
, Tuple.Create(Tuple.Create(" ", 377), Tuple.Create("list-unstyled", 378), true)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 391), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 392), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 408), Tuple.Create("\"", 451)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 421), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 421), false)
);

WriteLiteral(">\n\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
     for (int i = 0; i < Model.Items.Count(); i++)
    {
        var item = Model.Items.ElementAt(i);
        var thumbnailViewModel = (ThumbnailViewModel)item;

        var itemIndex = (Model.CurrentPage - 1) * ViewBag.ItemsPerPage + i + 1;
        var detailPageUrl = ViewBag.OpenInSamePage ? HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex) :
            HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"d-inline-block\"");

WriteLiteral(">\n            <a");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("href", Tuple.Create("\n               href=\"", 1060), Tuple.Create("\"", 1096)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1082), Tuple.Create<System.Object, System.Int32>(detailPageUrl
            
            #line default
            #line hidden
, 1082), false)
);

WriteAttribute("title", Tuple.Create("\n               title=\"", 1097), Tuple.Create("\"", 1158)
, Tuple.Create(Tuple.Create("", 1120), Tuple.Create("Go", 1120), true)
, Tuple.Create(Tuple.Create(" ", 1122), Tuple.Create("to", 1123), true)
, Tuple.Create(Tuple.Create(" ", 1125), Tuple.Create("image", 1126), true)
            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 1131), Tuple.Create<System.Object, System.Int32>(item.Fields.Title
            
            #line default
            #line hidden
, 1132), false)
, Tuple.Create(Tuple.Create(" ", 1150), Tuple.Create("details", 1151), true)
);

WriteLiteral(">\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1181), Tuple.Create("\"", 1221)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1187), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 1187), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1222), Tuple.Create("\'", 1320)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1228), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1228), false)
);

WriteLiteral("\n                     ");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
                Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                     ");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
                Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\n            </a>\n        </li>\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("  </ul>\n</div>\n\n");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ImageGallery.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
