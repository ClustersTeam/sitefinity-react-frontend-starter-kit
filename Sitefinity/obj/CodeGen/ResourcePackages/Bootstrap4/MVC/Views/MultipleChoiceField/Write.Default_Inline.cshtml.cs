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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.MultipleChoiceField
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/MultipleChoiceField/Write.Default_Inline." +
        "cshtml")]
    public partial class Write_Default_Inline : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default_Inline()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\n\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 692), Tuple.Create("\"", 726)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 700), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 700), false)
, Tuple.Create(Tuple.Create(" ", 715), Tuple.Create("form-group", 716), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\n    <legend");

WriteLiteral(" class=\"h6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 798), Tuple.Create("\'", 836)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 803), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 803), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                         Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\n\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 929), Tuple.Create("\'", 985)
, Tuple.Create(Tuple.Create("", 937), Tuple.Create("{", 937), true)
, Tuple.Create(Tuple.Create(" ", 938), Tuple.Create("\"required\":", 939), true)
, Tuple.Create(Tuple.Create(" ", 950), Tuple.Create("\"", 951), true)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  , Tuple.Create(Tuple.Create("", 952), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 952), false)
, Tuple.Create(Tuple.Create("", 983), Tuple.Create("\"}", 983), true)
);

WriteLiteral(" />\n\n    <ul");

WriteLiteral(" class=\"list-inline\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1018), Tuple.Create("\'", 1069)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1036), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 1036), false)
);

WriteLiteral(" ");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                  if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                           Write(Html.UniqueId("RadioGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                         } 
            
            #line default
            #line hidden
WriteLiteral(">\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                                (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var selctedAttributes = isSelected ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\n                <label>\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1734), Tuple.Create("\"", 1751)
            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1741), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1741), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1752), Tuple.Create("\"", 1767)
            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1760), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1760), false)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                   Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"radio\" aria-required=\"");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                   Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\n                </label>\n            </li>\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         if(Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\n                <label>\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2126), Tuple.Create("\"", 2143)
            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2133), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2133), false)
);

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" role=\"radio\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2250), Tuple.Create("\"", 2277)
            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create("", 2266), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2266), false)
);

WriteLiteral(" />\n");

WriteLiteral("                    ");

            
            #line 43 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                     Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                </label>\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2531), Tuple.Create("\"", 2558)
            
            #line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                     , Tuple.Create(Tuple.Create("", 2547), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2547), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2559), Tuple.Create("\"", 2601)
            
            #line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                              , Tuple.Create(Tuple.Create("", 2572), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 2572), false)
);

WriteLiteral(" />\n            </li>\n");

            
            #line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n");

            
            #line 50 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    
            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
     if (hasDescription) 
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 2686), Tuple.Create("\'", 2723)
            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2691), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupInfo")
            
            #line default
            #line hidden
, 2691), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                               Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</fieldset>\n\n");

            
            #line 56 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/MultipleChoiceField/multiple-choice-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
