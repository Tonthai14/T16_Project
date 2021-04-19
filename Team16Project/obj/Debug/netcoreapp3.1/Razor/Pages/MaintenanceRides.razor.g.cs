#pragma checksum "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f78a83985ef614c7d167fb5ea9f86dbe693afc"
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
#line 3 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
using Team16Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ridesNeedMaintenance")]
    public partial class MaintenanceRides : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Rides Currently Needing Maintenance</h3>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
 if (ridesNeedMaintenance == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading ride information...</em></p>\r\n");
#nullable restore
#line 15 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
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
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Ride ID</th>\r\n                <th>Ride Name</th>\r\n                <th>Ride Needs Maintenance?</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 27 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
             foreach (var ride in ridesNeedMaintenance)
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
#line 30 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
                         ride.RideId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
                         ride.RideName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
                         ride.NeedsMaintenance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 34 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
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
#line 37 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "\r\n");
            __builder.AddMarkupContent(27, "<h3>Do Maintenance On Ride</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(28);
            __builder.AddAttribute(29, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 40 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
                  newRidesNeedMaintenance

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 40 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
                                                           UpdateData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(33);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-12 row");
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "input");
                __builder2.AddAttribute(41, "class", "form-control col-4");
                __builder2.AddAttribute(42, "placeholder", "Ride Name");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
                                                 newRidesNeedMaintenance.RideName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newRidesNeedMaintenance.RideName = __value, newRidesNeedMaintenance.RideName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.AddMarkupContent(46, "<button type=\"submit\" class=\"btn btn-primary\">Do Maintenance</button>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\MaintenanceRides.razor"
       
    List<MaintenanceRideModel> ridesNeedMaintenance;
    private DisplayMaintenanceRideModel newRidesNeedMaintenance = new DisplayMaintenanceRideModel();

    private async Task UpdateData()
    {
        string query = "UPDATE RIDE SET TimesRidden = @TimesRidden, NeedsMaintenance = @NeedsMaintenance WHERE RideName = @RideName";
        string resetTableQuery = "SELECT RideId, RideName, NeedsMaintenance FROM RIDE WHERE RIDE.NeedsMaintenance = 'Y';";

        await _data.SaveData(query,
            new { TimesRidden = 0, NeedsMaintenance = 'N', RideName = newRidesNeedMaintenance.RideName },
            _config.GetConnectionString("default"));

        ridesNeedMaintenance = await _data.LoadData<MaintenanceRideModel, dynamic>(resetTableQuery, new { }, _config.GetConnectionString("default"));


    }

    protected override async Task OnInitializedAsync()
    {
        string query = "SELECT RideId, RideName, NeedsMaintenance FROM RIDE WHERE RIDE.NeedsMaintenance = 'Y';";

        ridesNeedMaintenance = await _data.LoadData<MaintenanceRideModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591