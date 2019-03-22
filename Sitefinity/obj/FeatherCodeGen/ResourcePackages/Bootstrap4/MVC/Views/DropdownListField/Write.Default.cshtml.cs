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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.DropdownListField
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
    
    #line 4 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/DropdownListField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.DropdownListField.DropdownListFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 10 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
  
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 474), Tuple.Create("\"", 508)
            
            #line 15 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 482), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 482), false)
, Tuple.Create(Tuple.Create(" ", 497), Tuple.Create("form-group", 498), true)
);

WriteLiteral(" data-sf-role=\"dropdown-list-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 614), Tuple.Create("\'", 670)
, Tuple.Create(Tuple.Create("", 622), Tuple.Create("{", 622), true)
, Tuple.Create(Tuple.Create(" ", 623), Tuple.Create("\"required\":", 624), true)
, Tuple.Create(Tuple.Create(" ", 635), Tuple.Create("\"", 636), true)
            
            #line 16 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
  , Tuple.Create(Tuple.Create("", 637), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 637), false)
, Tuple.Create(Tuple.Create("", 668), Tuple.Create("\"}", 668), true)
);

WriteLiteral(" />\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 696), Tuple.Create("\'", 728)
            
            #line 17 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 702), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Dropdown")
            
            #line default
            #line hidden
, 702), false)
);

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 18 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
   Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("\n    </label>\n    <select");

WriteAttribute("id", Tuple.Create(" \n        id=\'", 786), Tuple.Create("\'", 826)
            
            #line 21 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 800), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Dropdown")
            
            #line default
            #line hidden
, 800), false)
);

WriteLiteral("\n        data-sf-role=\"dropdown-list-field-select\"");

WriteAttribute("name", Tuple.Create("\n        name=\"", 877), Tuple.Create("\"", 918)
            
            #line 23 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 892), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 892), false)
);

WriteLiteral("\n        ");

            
            #line 24 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
   Write(MvcHtmlString.Create(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\n        class=\"form-control\"\n        aria-required=\"");

            
            #line 26 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                  Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\"\n");

            
            #line 27 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 27 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
          if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 27 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                   Write(Html.UniqueId("DropdownInfo"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 27 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                               } 
            
            #line default
            #line hidden
WriteLiteral(">\n");

            
            #line 28 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 28 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                            (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);
    
            var optionAttributes = isSelected ? "selected" : string.Empty;
            var optionValue = Model.IsRequired && choice == Model.Choices.FirstOrDefault() ? string.Empty : choice;


            
            #line default
            #line hidden
WriteLiteral("            <option ");

            
            #line 37 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
               Write(optionAttributes);

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 37 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                        Write(optionValue);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 37 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                      Write(choice);

            
            #line default
            #line hidden
WriteLiteral("</option>\n");

            
            #line 38 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </select>\n    \n");

            
            #line 41 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
     if (hasDescription) 
    { 

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1891), Tuple.Create("\'", 1926)
            
            #line 43 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1896), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("DropdownInfo")
            
            #line default
            #line hidden
, 1896), false)
);

WriteLiteral(">");

            
            #line 43 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
                                                             Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 44 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
    } 

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 47 "..\..MVC\Views\DropdownListField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/DropdownListField/dropdown-list-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591