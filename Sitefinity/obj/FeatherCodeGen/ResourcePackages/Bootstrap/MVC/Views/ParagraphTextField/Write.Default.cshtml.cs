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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.ParagraphTextField
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
    
    #line 4 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ParagraphTextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.ParagraphTextField.ParagraphTextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 335), Tuple.Create("\"", 369)
, Tuple.Create(Tuple.Create("", 343), Tuple.Create("form-group", 343), true)
            
            #line 10 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create(" ", 353), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 354), false)
);

WriteLiteral(" data-sf-role=\"paragraph-text-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 476), Tuple.Create("\'", 579)
, Tuple.Create(Tuple.Create("", 484), Tuple.Create("{\"maxLength\":\"", 484), true)
            
            #line 11 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
 , Tuple.Create(Tuple.Create("", 498), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 498), false)
, Tuple.Create(Tuple.Create("", 530), Tuple.Create("\",", 530), true)
, Tuple.Create(Tuple.Create(" ", 532), Tuple.Create("\"required\":", 533), true)
, Tuple.Create(Tuple.Create(" ", 544), Tuple.Create("\"", 545), true)
            
            #line 11 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                 , Tuple.Create(Tuple.Create("", 546), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 546), false)
, Tuple.Create(Tuple.Create("", 577), Tuple.Create("\"}", 577), true)
);

WriteLiteral(" />\n    <label");

WriteAttribute("for", Tuple.Create(" for=\'", 594), Tuple.Create("\'", 626)
            
            #line 12 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 600), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textarea")
            
            #line default
            #line hidden
, 600), false)
);

WriteLiteral(">");

            
            #line 12 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                       Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral(" </label>\n    <textarea");

WriteAttribute("id", Tuple.Create(" id=\'", 673), Tuple.Create("\'", 704)
            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 678), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textarea")
            
            #line default
            #line hidden
, 678), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" rows=\"4\"");

WriteLiteral(" data-sf-role=\"paragraph-text-field-textarea\"");

WriteAttribute("name", Tuple.Create(" name=\"", 780), Tuple.Create("\"", 813)
            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                , Tuple.Create(Tuple.Create("", 787), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 787), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 814), Tuple.Create("\"", 850)
            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                         , Tuple.Create(Tuple.Create("", 828), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 828), false)
);

WriteLiteral(" ");

            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                                                                                                           Write(MvcHtmlString.Create(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 13 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                                                                                                                                                             Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\n  \n");

            
            #line 15 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
     
            
            #line default
            #line hidden
            
            #line 15 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
      if (!string.IsNullOrEmpty(Model.MetaField.Description))
     {

            
            #line default
            #line hidden
WriteLiteral("         <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                          Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 18 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
     }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 21 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ParagraphTextField/paragraph-text-field.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
