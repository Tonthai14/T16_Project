#pragma checksum "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c951901c980ef2c552cf93f7da501fb620f8f4c"
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
#line 3 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
using Team16Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/staffrides")]
    public partial class StaffRides : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
 if (permitted)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h3>Please select the ride you\'re working at</h3>\r\n");
#nullable restore
#line 15 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
     if (rides == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<p><em>Loading ride information</em></p>\r\n");
#nullable restore
#line 18 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddMarkupContent(8, "<thead>\r\n                <tr>\r\n                    <th>Name</th>\r\n                    <th>Times Ridden</th>\r\n                    <th>Tickets To Ride</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 30 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                 foreach (var ride in rides)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 33 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                             ride.RideName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 34 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                             ride.TimesRidden

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 35 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                             ride.TicketsToRide

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                                                                                    (() => RideSelected(true, ride))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "\r\n                                Select\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 42 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 45 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.AddMarkupContent(37, "<p><em>You are not authorized to view this page.</em></p>\r\n");
#nullable restore
#line 50 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
       
    bool permitted = (Program.loggedInUser.Job == "Service");
    List<StaffRideModel> rides;
    private DisplayStaffRideModel thisRide = new DisplayStaffRideModel();
    private DisplayStaffRideModel rideSelected = new DisplayStaffRideModel();

    private void RideSelected(bool flag, StaffRideModel rideSelected)
    {
        rideSelected.isSelected = flag;
        NavManager.NavigateTo("/rideselected/" + rideSelected.RideId);
    }

    protected override async Task OnInitializedAsync()
    {
        string query = "SELECT * FROM RIDE";

        rides = await _data.LoadData<StaffRideModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
