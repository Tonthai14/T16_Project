<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#pragma checksum "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b35513008f5b2983d31fc22245884296fea036c"
=======
#pragma checksum "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be8a6013dcfc40f5bdd757add7ca2f5acf54cdf"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs
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
#line 1 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using Team16Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
using Team16Project.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 3 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
using Team16Project.Data;
=======
#line 3 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
using DataLibrary;
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs

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
            __builder.AddMarkupContent(0, "<h3>Rides Information</h3>\r\n\r\n");
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 10 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
 if (forecasts == null)
=======
#line 12 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
 if (rides == null)
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading ride information</em></p>\r\n");
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 13 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
=======
#line 15 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-striped");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Times Ridden</th>\r\n                <th>Tickets To Ride</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 26 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
=======
#line 27 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
             foreach (var ride in rides)
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 29 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()
=======
#line 30 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                         ride.RideName
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 30 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
                         forecast.TemperatureC
=======
#line 31 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                         ride.TimesRidden
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 31 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
                         forecast.TemperatureF
=======
#line 32 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
                         ride.TicketsToRide
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
=======
            __builder.AddMarkupContent(21, "\r\n                ");
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 34 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
=======
#line 34 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 37 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
=======
#line 37 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/FetchData.razor.g.cs
#line 39 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\FetchData.razor"
=======
#line 39 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\StaffRides.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb:Team16Project/obj/Debug/netcoreapp3.1/Razor/Pages/StaffRides.razor.g.cs
       
    List<StaffRideModel> rides;
    private DisplayStaffRideModel thisRide = new DisplayStaffRideModel();

    protected override async Task OnInitializedAsync()
    {
        string query = "SELECT * FROM RIDE";

        rides = await _data.LoadData<StaffRideModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
