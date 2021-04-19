#pragma checksum "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d074bebd38058b382a682cc601784d0434bec66"
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
#nullable restore
#line 11 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
 if (permitted)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h3>Staff Information</h3>\r\n");
#nullable restore
#line 15 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
     if (staff == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<p><em>Loading staff information...</em></p>\r\n");
#nullable restore
#line 18 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
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
            __builder.AddMarkupContent(8, "<thead>\r\n                <tr>\r\n                    <th>First Name</th>\r\n                    <th>Last Name</th>\r\n                    <th>Job</th>\r\n                    <th>Employee ID</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 31 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                 foreach (var employee in staff)
                {
                    if (employee.IsDeleted == "N")
                    {
                        if (employee.IsBeingEdited)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                                ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\r\n                                    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "placeholder", 
#nullable restore
#line 39 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                          employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                                                      employee.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.FirstName = __value, employee.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.OpenElement(24, "td");
            __builder.AddMarkupContent(25, "\r\n                                    ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "placeholder", 
#nullable restore
#line 42 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                          employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                                                     employee.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.LastName = __value, employee.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n                                    ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "placeholder", 
#nullable restore
#line 45 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                          employee.Job

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                                                employee.Job

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Job = __value, employee.Job));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 47 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                     employee.StaffId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                ");
            __builder.OpenElement(47, "td");
            __builder.AddMarkupContent(48, "\r\n                                    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                              () => UpdateStaff(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "\r\n                                        Save\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                ");
            __builder.OpenElement(56, "td");
            __builder.AddMarkupContent(57, "\r\n                                    ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                              () => EnableEdit(false, employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "\r\n                                        Cancel\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 59 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                            ");
            __builder.OpenElement(67, "tr");
            __builder.AddMarkupContent(68, "\r\n                                ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 63 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                     employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 64 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                     employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 65 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                     employee.Job

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                                ");
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, 
#nullable restore
#line 66 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                     employee.StaffId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.OpenElement(81, "td");
            __builder.AddMarkupContent(82, "\r\n                                    ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "type", "button");
            __builder.AddAttribute(85, "class", "btn btn-primary");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                              () => EnableEdit(true, employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "\r\n                                        Edit\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                ");
            __builder.OpenElement(90, "td");
            __builder.AddMarkupContent(91, "\r\n                                    ");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "type", "button");
            __builder.AddAttribute(94, "class", "btn btn-primary");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                                                              () => DeleteStaff(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(96, "\r\n                                        Delete\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 78 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                        }
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 83 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "    ");
            __builder.AddMarkupContent(104, "<h4>Add a new employee</h4>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(105);
            __builder.AddAttribute(106, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 86 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                      newStaff

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 86 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                InsertStaff

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(109, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(110);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(112);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\r\n\r\n        ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "col-12 row");
                __builder2.AddMarkupContent(116, "\r\n            ");
                __builder2.OpenElement(117, "input");
                __builder2.AddAttribute(118, "class", "form-control col-4");
                __builder2.AddAttribute(119, "placeholder", "First Name");
                __builder2.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                     newStaff.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newStaff.FirstName = __value, newStaff.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.OpenElement(123, "input");
                __builder2.AddAttribute(124, "class", "form-control col-4");
                __builder2.AddAttribute(125, "placeholder", "Last Name");
                __builder2.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                     newStaff.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newStaff.LastName = __value, newStaff.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n            ");
                __builder2.OpenElement(129, "input");
                __builder2.AddAttribute(130, "class", "form-control col-2");
                __builder2.AddAttribute(131, "placeholder", "Job");
                __builder2.AddAttribute(132, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                                     newStaff.Job

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(133, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newStaff.Job = __value, newStaff.Job));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n            ");
                __builder2.AddMarkupContent(135, "<button type=\"submit\" class=\"btn btn-primary\">Add Employee</button>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n        ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "col-12 row");
                __builder2.AddAttribute(139, "style", "text-align:left; font-weight:bold");
                __builder2.AddMarkupContent(140, "\r\n            ");
                __builder2.OpenElement(141, "span");
                __builder2.AddAttribute(142, "class", "col-12");
                __builder2.AddContent(143, 
#nullable restore
#line 97 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
                                  DisplayPwd

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 100 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "    ");
            __builder.AddMarkupContent(148, "<p><em>You are not authorized to view this page</em></p>\r\n");
#nullable restore
#line 104 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Staff.razor"
}

#line default
#line hidden
#nullable disable
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
