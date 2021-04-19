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
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
using Team16Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
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
#line 106 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
       
    bool permitted = (Program.loggedInUser.Job == "Manager");

    List<StaffModel> staff;
    private DisplayStaffModel newStaff = new DisplayStaffModel();
    public string DisplayPwd { get; set; }

    private void EnableEdit(bool flag, StaffModel staff)
    {
        staff.IsBeingEdited = flag;
    }

    private async Task InsertStaff()
    {
        const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder stringBuilder = new StringBuilder();
        Random random = new Random();
        int length = random.Next(2, 5);
        for(int i = 0; i < length; i++)
        {
            stringBuilder.Append(valid[random.Next(valid.Length)]);
        }
        string password = stringBuilder.ToString();
        string query = "INSERT INTO STAFF (FirstName, LastName, Job, Password, PARK_ParkId) VALUES (@FirstName, @LastName, @Job, @Password, 1);";

        await _data.SaveData(query,
            new { FirstName = newStaff.FirstName, LastName = newStaff.LastName, Job = newStaff.Job, Password = password },
            _config.GetConnectionString("default"));
        DisplayPwd = $"{newStaff.FirstName}'s temporary password is {password}";
        await OnInitializedAsync();
    }

    private async Task UpdateStaff(StaffModel staff)
    {
        EnableEdit(false, staff);
        string query = "UPDATE STAFF SET FirstName = @FirstName, LastName = @LastName, Job = @Job WHERE StaffId = @StaffId";

        await _data.SaveData(query,
            new { FirstName = staff.FirstName, LastName = staff.LastName, Job = staff.Job, StaffId = staff.StaffId },
            _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task DeleteStaff(StaffModel staff)
    {
        string query = "UPDATE STAFF SET FirstName = @FirstName, LastName = @LastName, Job = @Job, IsDeleted = @IsDeleted WHERE StaffId = @StaffId;";
        await _data.SaveData(query,
            new { FirstName = staff.FirstName, LastName = staff.LastName, Job = staff.Job, IsDeleted = "Y", StaffId = staff.StaffId },
            _config.GetConnectionString("default"));
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
