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
#line 3 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Staff.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Staff.razor"
using DataLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Staff.razor"
using Team16Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Staff.razor"
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
#line 53 "C:\Users\jonat\OneDrive\Desktop\T16R\Team16Project\Pages\Staff.razor"
       
    List<StaffModel> staff;
    private DisplayStaffModel newStaff = new DisplayStaffModel();

    private async Task InsertData()
    {
        string query = "insert into staff (FirstName, LastName, Job) values (@FirstName, @LastName, @Job);";

        await _data.SaveData(query, new { FirstName = "@FirstName", LastName = "@LastName" }, _config.GetConnectionString("default"));
    }

    private async Task UpdateData()
    {
        string query = "update staff set FirstName = @FirstName where LastName = @LastName";

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
