// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Team16Project.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
<<<<<<< HEAD
#line 1 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 1 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 2 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 3 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 4 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 5 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 6 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 7 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 8 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Team16Project;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\_Imports.razor"
=======
#line 9 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\_Imports.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Team16Project.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Rides.razor"
=======
#line 3 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Rides.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Rides.razor"
=======
#line 4 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Rides.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Rides.razor"
=======
#line 5 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Rides.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Team16Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Rides.razor"
=======
#line 6 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Rides.razor"
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rides")]
    public partial class Rides : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 49 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Rides.razor"
       
    List<RidesModel> rides;
    private DisplayRidesModel newRide = new DisplayRidesModel();

    private async Task InsertData()
    {
        string query = "INSERT INTO ride(ride_name, tickets_to_ride) values ('@RideName', '@TicketsRequired');";

        await _data.SaveData(query, new { RideName = "@RideName", TicketsRequired = "@TicketsRequired" }, _config.GetConnectionString("default"));
=======
#line 52 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Rides.razor"
       
    List<RideModel> rides;
    private DisplayRideModel newRide = new DisplayRideModel();

    private async Task InsertData()
    {
        string query = "INSERT INTO RIDE(TimesRidden, TicketsToRide) VALUES (@TimesRidden, @TicketsToRide);";

        await _data.SaveData(query,
            new { TimesRidden = 0, TicketsToRide = newRide.TicketsToRide },
            _config.GetConnectionString("default"));
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
    }

    private async Task UpdateData()
    {
<<<<<<< HEAD
        string query = "update ride set TicketsRequired = @TicketsRequired where RideName = @RideName";

        await _data.SaveData(query, new { TicketsRequired = "@TicketsRequired", RideName = "@RideName" }, _config.GetConnectionString("default"));
=======
        string query = "UPDATE RIDE SET tickets_to_ride = @tickets_to_ride WHERE ride_id = @ride_id";

        await _data.SaveData(query, new { FirstName = "@FirstName", LastName = "@LastName" }, _config.GetConnectionString("default"));
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb

        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string query = "SELECT * FROM RIDE";

<<<<<<< HEAD
        rides = await _data.LoadData<RidesModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
=======
        rides = await _data.LoadData<RideModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
>>>>>>> 85184454f723dacbfc4e31912099d9f17a119edb
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
