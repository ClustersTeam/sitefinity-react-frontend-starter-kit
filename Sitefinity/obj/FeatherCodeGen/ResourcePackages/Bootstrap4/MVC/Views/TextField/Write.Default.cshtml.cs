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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.TextField
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
    
    #line 4 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/TextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField.TextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 9 "..\..MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n<!-- InputCssClass class variable -->\n\n");

            
            #line 12 "..\..MVC\Views\TextField\Write.Default.cshtml"
   
    var inputCssClass = "";
    HashSet<TextType> availableOptions = new HashSet<TextType>() { TextType.Text, TextType.Password, TextType.Date, TextType.DateTimeLocal, TextType.Month, TextType.Time,
    TextType.Week, TextType.Number, TextType.Email,TextType.Url, TextType.Tel, TextType.Color };

    if (availableOptions.Contains(Model.InputType))
    {
        inputCssClass = "form-control";
    }

    var isRequired = Model.ValidatorDefinition.Required.HasValue && Model.ValidatorDefinition.Required.Value ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1040), Tuple.Create("\"", 1074)
            
            #line 26 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1048), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1048), false)
, Tuple.Create(Tuple.Create(" ", 1063), Tuple.Create("form-group", 1064), true)
);

WriteLiteral(" data-sf-role=\"text-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" data-sf-role=\"violation-restrictions\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1175), Tuple.Create("\'", 1288)
, Tuple.Create(Tuple.Create("", 1183), Tuple.Create("{\"maxLength\":\"", 1183), true)
            
            #line 27 "..\..MVC\Views\TextField\Write.Default.cshtml"
    , Tuple.Create(Tuple.Create("", 1197), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLength
            
            #line default
            #line hidden
, 1197), false)
, Tuple.Create(Tuple.Create("", 1233), Tuple.Create("\",", 1233), true)
, Tuple.Create(Tuple.Create(" ", 1235), Tuple.Create("\"minLength\":", 1236), true)
, Tuple.Create(Tuple.Create(" ", 1248), Tuple.Create("\"", 1249), true)
            
            #line 27 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 1250), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MinLength
            
            #line default
            #line hidden
, 1250), false)
, Tuple.Create(Tuple.Create("", 1286), Tuple.Create("\"}", 1286), true)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1351), Tuple.Create("\'", 1631)
, Tuple.Create(Tuple.Create("", 1359), Tuple.Create("{\"maxLength\":\"", 1359), true)
            
            #line 28 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1373), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1373), false)
, Tuple.Create(Tuple.Create("", 1425), Tuple.Create("\",", 1425), true)
, Tuple.Create(Tuple.Create(" ", 1427), Tuple.Create("\"required\":", 1428), true)
, Tuple.Create(Tuple.Create(" ", 1439), Tuple.Create("\"", 1440), true)
            
            #line 28 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                    , Tuple.Create(Tuple.Create("", 1441), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 1441), false)
, Tuple.Create(Tuple.Create("", 1492), Tuple.Create("\",", 1492), true)
, Tuple.Create(Tuple.Create(" ", 1494), Tuple.Create("\"invalid\":", 1495), true)
, Tuple.Create(Tuple.Create(" ", 1505), Tuple.Create("\"", 1506), true)
            
            #line 28 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                      , Tuple.Create(Tuple.Create("", 1507), Tuple.Create<System.Object, System.Int32>(Html.Resource("InvalidEntryMessage")
            
            #line default
            #line hidden
, 1507), false)
, Tuple.Create(Tuple.Create("", 1544), Tuple.Create("\",", 1544), true)
, Tuple.Create(Tuple.Create(" ", 1546), Tuple.Create("\"regularExpression\":", 1547), true)
, Tuple.Create(Tuple.Create(" ", 1567), Tuple.Create("\"", 1568), true)
            
            #line 28 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RegularExpressionViolationMessage
            
            #line default
            #line hidden
, 1569), false)
, Tuple.Create(Tuple.Create("", 1629), Tuple.Create("\"}", 1629), true)
);

WriteLiteral(" />\n\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 1658), Tuple.Create("\'", 1689)
            
            #line 30 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1664), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1664), false)
);

WriteLiteral(">");

            
            #line 30 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                 Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\n    <input");

WriteAttribute("id", Tuple.Create(" \n        id=\'", 1732), Tuple.Create("\'", 1771)
            
            #line 32 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1746), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1746), false)
);

WriteAttribute("type", Tuple.Create("\n        type=\"", 1772), Tuple.Create("\"", 1821)
            
            #line 33 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1787), Tuple.Create<System.Object, System.Int32>(Model.InputType.ToHtmlInputType()
            
            #line default
            #line hidden
, 1787), false)
);

WriteAttribute("class", Tuple.Create("\n        class=\"", 1822), Tuple.Create("\"", 1852)
            
            #line 34 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1838), Tuple.Create<System.Object, System.Int32>(inputCssClass
            
            #line default
            #line hidden
, 1838), false)
);

WriteAttribute("name", Tuple.Create("\n        name=\"", 1853), Tuple.Create("\"", 1894)
            
            #line 35 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1868), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1868), false)
);

WriteAttribute("placeholder", Tuple.Create("\n        placeholder=\"", 1895), Tuple.Create("\"", 1939)
            
            #line 36 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1917), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 1917), false)
);

WriteAttribute("value", Tuple.Create("\n        value=\"", 1940), Tuple.Create("\"", 1968)
            
            #line 37 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1956), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 1956), false)
);

WriteAttribute("aria-required", Tuple.Create("\n        aria-required=\"", 1969), Tuple.Create("\"", 2004)
            
            #line 38 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 1993), false)
);

WriteLiteral("\n        data-sf-role=\"text-field-input\"");

WriteLiteral("\n        ");

            
            #line 40 "..\..MVC\Views\TextField\Write.Default.cshtml"
   Write(Html.Raw(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 41 "..\..MVC\Views\TextField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\TextField\Write.Default.cshtml"
          if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 41 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                   Write(Html.UniqueId("TextboxInfo"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 41 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                              } 
            
            #line default
            #line hidden
WriteLiteral(" />\n");

            
            #line 42 "..\..MVC\Views\TextField\Write.Default.cshtml"
     
            
            #line default
            #line hidden
            
            #line 42 "..\..MVC\Views\TextField\Write.Default.cshtml"
      if (hasDescription) 
     {

            
            #line default
            #line hidden
WriteLiteral("         <p");

WriteAttribute("id", Tuple.Create(" id=\'", 2238), Tuple.Create("\'", 2272)
            
            #line 44 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2243), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("TextboxInfo")
            
            #line default
            #line hidden
, 2243), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 44 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                             Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 45 "..\..MVC\Views\TextField\Write.Default.cshtml"
     }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 48 "..\..MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/TextField/text-field.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591