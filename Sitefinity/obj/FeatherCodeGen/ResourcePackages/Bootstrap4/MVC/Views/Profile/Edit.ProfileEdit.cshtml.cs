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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Profile
{
    using System;
    
    #line 3 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    
    #line 4 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using System.Linq.Expressions;
    
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
    
    #line 6 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Profile/Edit.ProfileEdit.cshtml")]
    public partial class Edit_ProfileEdit : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile.ProfileEditViewModel>
    {

#line 130 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<ProfileEditViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 131 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
 
    var hasValidationMessage = Html.ValidationMessageFor(expression) != null;
    var attributes = new Dictionary<string, object>();
    var cls = "form-control";

    if (classValue != null)
    {
        cls += " " + classValue;
    }

    attributes.Add("class", cls);

    if (hasValidationMessage)
    {
        attributes.Add("aria-describedby", Html.UniqueId(descId));
    }
    if (additionalAttributes != null)
    {
        attributes = attributes.Concat(additionalAttributes).ToDictionary(x => x.Key, x => x.Value);
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"form-group\"");

WriteLiteralTo(__razor_helper_writer, ">\n\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 154 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n\n");


#line 156 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        

#line default
#line hidden

#line 156 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 159 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 159 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 163 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 163 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 167 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 167 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n");


#line 174 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        

#line default
#line hidden

#line 174 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 7636), Tuple.Create("\'", 7663)

#line 176 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 7641), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 7641), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"form-text\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 177 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
          WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\n            </div>\n");


#line 179 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\n");


#line 181 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"


#line default
#line hidden
});

#line 181 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
}
#line default
#line hidden

        public Edit_ProfileEdit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 12 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 13 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 14 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 655), Tuple.Create("\"", 678)
            
            #line 16 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 663), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 663), false)
);

WriteLiteral(">\n\n    <h3>");

            
            #line 18 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
   Write(Html.Resource("EditProfileLink"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 20 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     if (Model.ShowProfileChangedMsg)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                       Write(Html.Resource("ChangesAreSaved"));

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 23 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 25 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     if (!string.IsNullOrEmpty(ViewBag.ErrorMessage))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                      Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 28 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 30 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 30 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     using (Html.BeginFormSitefinity("Index", "EditProfileForm", FormMethod.Post, new Dictionary<string, object> { { "enctype", "multipart/form-data" }, { "role", "form" } }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"media sf-profile\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"sf-profile-aside media-left\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 34 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.HiddenFor(u => u.DeletePicture, new Dictionary<string, object>() { { "data-sf-role", "edit-profile-delete-picture" } }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 35 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.HiddenFor(u => u.DefaultAvatarUrl, new Dictionary<string, object>() { { "data-sf-role", "edit-profile-default-avatar-url" } }));

            
            #line default
            #line hidden
WriteLiteral("\n                <div");

WriteLiteral(" class=\"media-object\"");

WriteLiteral(">\n                  <div");

WriteLiteral(" class=\"sf-profile-avatar\"");

WriteLiteral(">\n                       <img");

WriteLiteral(" data-sf-role=\"edit-profile-user-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1792), Tuple.Create("\"", 1819)
            
            #line 38 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1798), Tuple.Create<System.Object, System.Int32>(Model.AvatarImageUrl
            
            #line default
            #line hidden
, 1798), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1820), Tuple.Create("\"", 1841)
            
            #line 38 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                    , Tuple.Create(Tuple.Create("", 1826), Tuple.Create<System.Object, System.Int32>(Model.UserName
            
            #line default
            #line hidden
, 1826), false)
);

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral("/>\n                        ");

WriteLiteral("\n                    </div>\n                  <div>\n                        <inpu" +
"t");

WriteLiteral(" type=\"file\"");

WriteLiteral(" data-sf-role=\"edit-profile-upload-picture-input\"");

WriteLiteral(" name=\"UploadedImage\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" />\n                        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"edit-profile-upload-picture-button\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(">");

            
            #line 45 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                                Write(Html.Resource("EditProfileUploadImage"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n                    </div>\n                </div>\n            </div> \n      " +
"      <div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\n\n");

WriteLiteral("                ");

            
            #line 51 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(FormGroupPanel("EditProfileFirstName", u => u.Profile["FirstName"], "ProfileFirstName"));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

WriteLiteral("                ");

            
            #line 53 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(FormGroupPanel("EditProfileLastName", u => u.Profile["LastName"], "ProfileLastName"));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

WriteLiteral("                ");

            
            #line 55 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(FormGroupPanel("EditProfileNickname", u => u.Profile["Nickname"], "ProfileNickName"));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

WriteLiteral("                ");

            
            #line 57 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(FormGroupPanel("EditProfileAbout", u => u.Profile["About"], "ProfileAbout", "textarea"));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 59 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 59 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (string.IsNullOrEmpty(Model.ExternalProviderName))
                {
                    
            
            #line default
            #line hidden
            
            #line 61 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileEmail", u => u.Email, "ProfileEmail"));

            
            #line default
            #line hidden
            
            #line 61 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                     


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(">\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"edit-profile-change-password-button\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(">\n");

WriteLiteral("                            ");

            
            #line 65 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileChangePasswordButton"));

            
            #line default
            #line hidden
WriteLiteral("\n                            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 66 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                             Write(Html.Resource("WillExpandChangePasswordSection"));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </a>\n                    </div>\n");

WriteLiteral("                    <div");

WriteLiteral(" data-sf-role=\"edit-profile-change-password-holder\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\n                        <h4>");

            
            #line 70 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileEditChangePasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\n\n");

WriteLiteral("                        ");

            
            #line 72 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileOldPassword", u => u.OldPassword, "ProfileOldPassword", "password", null, new Dictionary<string, object>(){{"autocomplete", "off"}}));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

WriteLiteral("                        ");

            
            #line 74 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileNewPassword", u => u.NewPassword, "ProfileNewPassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

WriteLiteral("                        ");

            
            #line 76 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileRepeatPassword", u => u.RepeatPassword, "ProfileRepeatPassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n");

            
            #line 78 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h4>");

            
            #line 81 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(string.Format(Html.Resource("RegistratedWithExternal"), Model.ExternalProviderName));

            
            #line default
            #line hidden
WriteLiteral("</h4>\n");

            
            #line 82 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                        <label>\n");

WriteLiteral("                            ");

            
            #line 85 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileEmail"));

            
            #line default
            #line hidden
WriteLiteral("\n                        </label>\n                        <div>\n");

WriteLiteral("                            ");

            
            #line 88 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.HiddenFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                            ");

            
            #line 89 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Model.Email);

            
            #line default
            #line hidden
WriteLiteral("\n                        </div>\n                    </div>\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                        <label>\n");

WriteLiteral("                            ");

            
            #line 94 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("Password"));

            
            #line default
            #line hidden
WriteLiteral("\n                        </label>\n                        <div>\n");

WriteLiteral("                            ");

            
            #line 97 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(string.Format(Html.Resource("ExternalProviderNoPassword"), Model.ExternalProviderName));

            
            #line default
            #line hidden
WriteLiteral("\n                        </div>\n                    </div>\n");

            
            #line 100 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 102 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 102 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (SystemManager.IsDesignMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 104 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                           Write(Html.Resource("EditProfileSave"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 105 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 108 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                           Write(Html.Resource("EditProfileSave"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 109 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 111 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 111 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (SystemManager.IsPreviewMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"profile-submit-preview-message\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"form-text\"");

WriteLiteral("><span");

WriteLiteral(" class=\"field-validation-error\"");

WriteLiteral(">");

            
            #line 114 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                Write(Html.Resource("PreviewProfileSaveMessage"));

            
            #line default
            #line hidden
WriteLiteral("</span></span>\n                    </div>\n");

            
            #line 116 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n        </div>\n");

            
            #line 119 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 122 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
  
    bool hasPasswordErrors = ViewBag.HasPasswordErrors is bool && ViewBag.HasPasswordErrors == true;

            
            #line default
            #line hidden
WriteLiteral("\n\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"has-password-errors\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6156), Tuple.Create("\"", 6212)
            
            #line 126 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 6164), Tuple.Create<System.Object, System.Int32>(hasPasswordErrors.ToString().ToLowerInvariant()
            
            #line default
            #line hidden
, 6164), false)
);

WriteLiteral(" />\n\n");

            
            #line 128 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Profile/profile-edit.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

        }
    }
}
#pragma warning restore 1591
