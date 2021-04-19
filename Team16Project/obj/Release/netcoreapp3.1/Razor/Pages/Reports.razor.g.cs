#pragma checksum "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95351ca6194d01d397ba75bc300f464dfe5e52b0"
// <auto-generated/>
#pragma warning disable 1591
namespace Team16Project.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using Team16Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
using Team16Project.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
using Team16Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/reports")]
    public partial class Reports : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Generate Reports</h2>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
 if (rideReportGenerated)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<thead>\r\n            <tr>\r\n                <th>Ride ID</th>\r\n                <th>Avg Times Ridden</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 23 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
             foreach (var ride in generatedRideReport)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 26 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                         ride.RideId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                         ride.TimesRidden

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 29 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 32 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 34 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
 if (customerReportGenerated)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-striped");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<thead>\r\n            <tr>\r\n                <th>Month</th>\r\n                <th>Year</th>\r\n                <th>Avg Number of Customers</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(27, "tbody");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 45 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
             foreach (var customer in generatedCustomerReport)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 48 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                         customer.Month

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 49 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                         customer.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 50 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                         customer.NumCustomers

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 52 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 55 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 57 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
 if (rideDates == null || customerDates == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "    ");
            __builder.AddMarkupContent(47, "<p>Loading page...</p>\r\n");
#nullable restore
#line 60 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.AddMarkupContent(52, "<div class=\"card-header\" style=\"font-weight:bold; color:black\">Ride Reports</div>\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "card-body");
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(56);
            __builder.AddAttribute(57, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 66 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                              rideReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 66 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                                          FetchRideReport

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(61);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(63);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n\r\n                ");
                __builder2.OpenElement(65, "select");
                __builder2.AddAttribute(66, "class", "form-control selectpicker");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                                                 rideReport.ReportType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rideReport.ReportType = __value, rideReport.ReportType));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __builder2.OpenElement(70, "option");
                __builder2.AddContent(71, "--Select Report Type--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.OpenElement(73, "option");
                __builder2.AddContent(74, "Most frequently ridden");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenElement(76, "option");
                __builder2.AddContent(77, "Most breakdowns");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.OpenElement(80, "select");
                __builder2.AddAttribute(81, "class", "form-control selectpicker");
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                                                 rideReport.StartDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rideReport.StartDate = __value, rideReport.StartDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.OpenElement(85, "option");
                __builder2.AddContent(86, "--Select Start Date--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n");
#nullable restore
#line 77 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                     foreach (var date in rideDates)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(88, "                        ");
                __builder2.OpenElement(89, "option");
                __builder2.AddContent(90, 
#nullable restore
#line 79 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                 date.Date.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n");
#nullable restore
#line 80 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(92, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.OpenElement(94, "select");
                __builder2.AddAttribute(95, "class", "form-control selectpicker");
                __builder2.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                                                 rideReport.EndDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rideReport.EndDate = __value, rideReport.EndDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __builder2.OpenElement(99, "option");
                __builder2.AddContent(100, "--Select End Date--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n");
#nullable restore
#line 84 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                     foreach (var date in rideDates)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(102, "                        ");
                __builder2.OpenElement(103, "option");
                __builder2.AddContent(104, 
#nullable restore
#line 86 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                 date.Date.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n");
#nullable restore
#line 87 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(106, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                ");
                __builder2.AddMarkupContent(108, "<button type=\"submit\" class=\"btn btn-primary\">Get Report</button>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
            __builder.AddContent(112, "    ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "card");
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.AddMarkupContent(116, "<div class=\"card-header\" style=\"font-weight:bold; color:black\">Customer Reports</div>\r\n        ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "card-body");
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(120);
            __builder.AddAttribute(121, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 97 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                              customerReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 97 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                                              FetchCustomerReport

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(124, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(125);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(126, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(127);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n\r\n                ");
                __builder2.OpenElement(129, "select");
                __builder2.AddAttribute(130, "class", "form-control selectpicker");
                __builder2.AddAttribute(131, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 101 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                                                 customerReport.ReportType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(132, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customerReport.ReportType = __value, customerReport.ReportType));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(133, "\r\n                    ");
                __builder2.OpenElement(134, "option");
                __builder2.AddContent(135, "--Select Report Type--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n                    ");
                __builder2.OpenElement(137, "option");
                __builder2.AddContent(138, "Most customers");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n                ");
                __builder2.OpenElement(141, "select");
                __builder2.AddAttribute(142, "class", "form-control selectpicker");
                __builder2.AddAttribute(143, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                                                 customerReport.StartDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(144, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customerReport.StartDate = __value, customerReport.StartDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(145, "\r\n                    ");
                __builder2.OpenElement(146, "option");
                __builder2.AddContent(147, "--Select Start Date--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n");
#nullable restore
#line 107 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                     foreach (var date in customerDates)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(149, "                        ");
                __builder2.OpenElement(150, "option");
                __builder2.AddContent(151, 
#nullable restore
#line 109 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                 date.Date.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n");
#nullable restore
#line 110 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(153, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n                ");
                __builder2.OpenElement(155, "select");
                __builder2.AddAttribute(156, "class", "form-control selectpicker");
                __builder2.AddAttribute(157, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 112 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                                                 customerReport.EndDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customerReport.EndDate = __value, customerReport.EndDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(159, "\r\n                    ");
                __builder2.OpenElement(160, "option");
                __builder2.AddContent(161, "--Select End Date--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n");
#nullable restore
#line 114 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                     foreach (var date in customerDates)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(163, "                        ");
                __builder2.OpenElement(164, "option");
                __builder2.AddContent(165, 
#nullable restore
#line 116 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                                 date.Date.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\r\n");
#nullable restore
#line 117 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(167, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n                ");
                __builder2.AddMarkupContent(169, "<button type=\"submit\" class=\"btn btn-primary\">Get Report</button>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(170, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n");
#nullable restore
#line 123 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Reports.razor"
       
    List<RideDateModel> rideDates;
    List<CustomerReportModel> customerDates;
    private DisplayReportModel rideReport = new DisplayReportModel();
    private DisplayReportModel customerReport = new DisplayReportModel();
    bool rideReportGenerated = false;
    bool customerReportGenerated = false;
    List<RideReportModel> generatedRideReport;
    List<CustomerReportModel> generatedCustomerReport;

    private async Task FetchCustomerReport()
    {
        customerReportGenerated = false;
        var startDate = customerReport.StartDate.Date;
        var endDate = customerReport.EndDate.Date;

        string query = "SELECT MONTH(EnteredPark) AS Month, YEAR(EnteredPark) AS Year, COUNT(*) AS NumCustomers " +
                "FROM CUSTOMER WHERE DATE(EnteredPark) >= @startDate AND DATE(EnteredPark) <= @endDate " +
                "GROUP BY MONTH(EnteredPark) ORDER BY Month DESC, YEAR DESC;";
        generatedCustomerReport = await _data.LoadData<CustomerReportModel, dynamic>(query,
            new { startDate = startDate, endDate = endDate },
            _config.GetConnectionString("default"));
        customerReportGenerated = true;
        await OnInitializedAsync();
    }

    private async Task FetchRideReport()
    {
        rideReportGenerated = false;
        var startDate = rideReport.StartDate.Date;
        var endDate = rideReport.EndDate.Date;

        string query = "SELECT RIDE_RideId AS RideId, AVG(TimesRidden) AS TimesRidden " +
                        "FROM RIDE_DATE WHERE Date >= @startDate AND Date <= @endDate " +
                        "GROUP BY MONTH(Date), RideId ORDER BY TimesRidden DESC;";
        generatedRideReport = await _data.LoadData<RideReportModel, dynamic>(query,
            new { startDate = startDate, endDate = endDate },
            _config.GetConnectionString("default"));
        rideReportGenerated = true;
        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string rideQuery = "SELECT DISTINCT Date FROM RIDE_DATE ORDER BY Date ASC;";
        rideDates = await _data.LoadData<RideDateModel, dynamic>(rideQuery, new { }, _config.GetConnectionString("default"));
        string customerQuery = "SELECT DISTINCT DATE(EnteredPark) AS Date FROM CUSTOMER ORDER BY Date ASC;";
        customerDates = await _data.LoadData<CustomerReportModel, dynamic>(customerQuery, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
