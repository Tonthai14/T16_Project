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
#line 3 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
using Team16Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/staff")]
    public partial class Staff : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
       
    List<StaffModel> staff;
    private DisplayStaffModel newStaff = new DisplayStaffModel();

    private async Task InsertStaff()
    {
        string query = "INSERT INTO STAFF (FirstName, LastName, Job, PARK_ParkId) VALUES (@FirstName, @LastName, @Job, 0);";

        await _data.SaveData(query,
            new { FirstName = newStaff.FirstName, LastName = newStaff.LastName, Job = newStaff.Job },
            _config.GetConnectionString("default"));
        // Get StaffId of most recent database entry in STAFF table
        string getId = "SELECT StaffId FROM STAFF ORDER BY CreateDate DESC LIMIT 1;";
        List<int> id = await _data.LoadData<int, dynamic>(getId,
            new { FirstName = newStaff.FirstName, LastName = newStaff.LastName, Job = newStaff.Job },
            _config.GetConnectionString("default"));
        StaffModel employee = new StaffModel
        {
            FirstName = newStaff.FirstName,
            LastName = newStaff.LastName,
            Job = newStaff.Job,
            StaffId = id.ElementAt(0) // List should only contain single employee ID
        };
        staff.Add(employee);
        // Reset so new employee variable has clean slate of information
        newStaff = new DisplayStaffModel();
    }

    private async Task UpdateData()
    {
        string query = "UPDATE STAFF SET FirstName = @FirstName WHERE LastName = @LastName";

        await _data.SaveData(query, new { FirstName = "@FirstName", LastName = "@LastName" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string query = "SELECT * FROM STAFF";

        staff = await _data.LoadData<StaffModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591