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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.EventScheduler
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
    
    #line 2 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
    using ServiceStack.Text;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/EventScheduler/List.Calendar.cshtml")]
    public partial class List_Calendar : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Events.Mvc.Models.EventScheduler.EventSchedulerModel>
    {
        public List_Calendar()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_common_min.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
 if (Html.ShouldRenderInlineEditing() || SystemManager.IsDesignMode || SystemManager.IsPreviewMode)
{
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_bootstrap_min.css"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                  

    if (ViewBag.IsRtl)
    {
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
   Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_rtl_min.css"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                
    }
}
else
{
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_bootstrap_min.css"), "head", false));

            
            #line default
            #line hidden
            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                

    if (ViewBag.IsRtl)
    {
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
   Write(Html.StyleSheet(Url.EmbeddedResource("Telerik.Sitefinity.Resources.Reference", "Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_rtl_min.css"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                
    }
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" data-sf-current-page-id=\'");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                         Write(ViewBag.CurrentPageId);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-widget-id=\'");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                    Write(ViewBag.WidgetId);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-role=\"scheduler-wrapper\"");

WriteLiteral(" data-sf-rtl=\"");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                     Write(ViewBag.IsRtl);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\'", 1579), Tuple.Create("\'", 1606)
            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                 , Tuple.Create(Tuple.Create("", 1587), Tuple.Create<System.Object, System.Int32>(Model.ListCssClass
            
            #line default
            #line hidden
, 1587), false)
);

WriteLiteral(" data-sf-controller-events=\'");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                                            Write(Url.Content("~/web-interface/events"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-controller-calendars=\'");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                                                                                                                  Write(Url.Content("~/web-interface/calendars"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-siteid=\"");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                                                                                                                                                                             Write(SystemManager.CurrentContext.CurrentSite.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\n    data-sf-defaultview=\'");

            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                    Write(Model.EventSchedulerViewMode);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-allowchangecalendarview=\'");

            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                    Write(Json.Encode(Model.AllowChangeCalendarView));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-allowcalendarfilter=\'");

            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                              Write(Json.Encode(Model.AllowCalendarFilter));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-weekstartday=\'");

            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                                                             Write(Model.WeekStartDay);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-loaded=\'false\'");

WriteLiteral(" \n\tdata-sf-mincalendarlength=\'2\'");

WriteLiteral(" data-sf-calendarlist-class-active=\'active\'");

WriteLiteral(" data-sf-uiculture=\'");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                           Write(ViewBag.UiCulture);

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" data-sf-timezoneoffset=\"");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                       Write(ViewBag.TimeZoneOffset);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-sf-timezoneid=\"");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                                                                    Write(ViewBag.TimeZoneId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-sf-localtimezoneoffset=\"\"");

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\n            <div");

WriteLiteral(" data-sf-role=\"scheduler\"");

WriteLiteral("></div>\n        </div>\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
        
            
            #line default
            #line hidden
            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
         if (Model.AllowCalendarFilter) {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\n            <div");

WriteLiteral(" data-sf-role=\"calendarlist\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\n                <h4");

WriteLiteral(" class=\"sf-calendarList-title\"");

WriteLiteral(">");

            
            #line 38 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                             Write(Html.Resource("Calendars"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\n            </div>\n        </div>\n");

            
            #line 41 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\n    <script");

WriteLiteral(" data-sf-role=\"event-alldayeventtemplate\"");

WriteLiteral(" type=\"text/x-kendo-tmpl\"");

WriteLiteral(">\n        <div class=\"sf-event-item\" data-sf-eventid=\"#= taskId #\" data-sf-date-s" +
"tart=#= JSON.stringify(start) # data-sf-date-end=#= JSON.stringify(end) # data-s" +
"f-allday=\"#= isAllDay #\">\n\t\t\t<a class=\"sf-event-link\" href=\"");

            
            #line 45 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                      Write(Html.Raw(Html.Encode(HyperLinkHelpers.GetFullPageUrl(ViewBag.DetailsPageId)).Replace("#", "\\#")));

            
            #line default
            #line hidden
WriteLiteral("#= eventUrl #\" title=\"#= title #\">#= title #</a>\n\t\t</div>\n    </script>\n    <scri" +
"pt");

WriteLiteral(" data-sf-role=\"event-eventtemplate\"");

WriteLiteral(" type=\"text/x-kendo-tmpl\"");

WriteLiteral(">\n\t\t<div class=\"sf-event-item\" data-sf-eventid=\"#= taskId #\" data-sf-date-start=#" +
"= JSON.stringify(start) # data-sf-date-end=#= JSON.stringify(end) # data-sf-alld" +
"ay=\"#= isAllDay #\">\n\t\t\t<a class=\"sf-event-link\" href=\"");

            
            #line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                      Write(Html.Raw(Html.Encode(HyperLinkHelpers.GetFullPageUrl(ViewBag.DetailsPageId)).Replace("#", "\\#")));

            
            #line default
            #line hidden
WriteLiteral("#= eventUrl #\" title=\"#= title #\">#= title #</a>\n\t\t</div>\n    </script>\n    <scri" +
"pt");

WriteLiteral(" data-sf-role=\"event-calendarlist-template-wrapper\"");

WriteLiteral(" type=\"text/x-kendo-tmpl\"");

WriteLiteral(">\n        <div data-sf-role=\"calendarlist-wrapper\" class=\"list-unstyled nav nav-p" +
"ills nav-stacked\">\n            <div data-sf-role=\"calendarlist-item\" class=\"sf-c" +
"alendarList-item active\"><span class=\"sf-event-type sf-event-type--all\"></span>");

            
            #line 55 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                                                       Write(Html.Resource("AllEvents"));

            
            #line default
            #line hidden
WriteLiteral("</div>\n        </div>\n    </script>\n    <script");

WriteLiteral(" data-sf-role=\"event-calendarlist-template-item\"");

WriteLiteral(" type=\"text/x-kendo-tmpl\"");

WriteLiteral(">\n        <div data-sf-role=\"calendarlist-item\" class=\"sf-calendarList-item\" data" +
"-sf-id=\"#= calendarId #\"><span class=\"sf-event-type\" style=\"background-color: #=" +
" color #;\"></span>#= title #</div>\n    </script>\t\n</div>\n");

            
            #line 62 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
 if (SystemManager.IsDesignMode && !SystemManager.IsPreviewMode)
{
    var scriptUrl = Url.WidgetContent("Mvc/Scripts/EventScheduler/scheduler-events.js");
    var fullScriptUrl = scriptUrl + (scriptUrl.Contains("?") ? "&" : "?") + string.Format("_={0}", DateTime.UtcNow.Ticks.ToString());

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\'", 4654), Tuple.Create("\'", 4674)
            
            #line 66 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
, Tuple.Create(Tuple.Create("", 4660), Tuple.Create<System.Object, System.Int32>(fullScriptUrl
            
            #line default
            #line hidden
, 4660), false)
);

WriteLiteral("></script>\n");

            
            #line 67 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
}
else
{
	
            
            #line default
            #line hidden
            
            #line 70 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
            
            #line 70 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                
	
            
            #line default
            #line hidden
            
            #line 71 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.Script(ScriptRef.KendoAll, "top", false));

            
            #line default
            #line hidden
            
            #line 71 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                  
	
            
            #line default
            #line hidden
            
            #line 72 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.Script(ScriptRef.KendoTimezones, "top", false));

            
            #line default
            #line hidden
            
            #line 72 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                        
    
            
            #line default
            #line hidden
            
            #line 73 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/EventScheduler/scheduler-events.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 73 "..\..\ResourcePackages\Bootstrap\MVC\Views\EventScheduler\List.Calendar.cshtml"
                                                                                                      
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
