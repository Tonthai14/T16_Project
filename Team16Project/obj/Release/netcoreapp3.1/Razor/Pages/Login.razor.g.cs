#pragma checksum "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8113dfd52b1e7715751337e65120f61c783db459"
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
#line 4 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
using Team16Project.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
                  employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
                                            ValidateLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddMarkupContent(5, "<div>\r\n        <br><br><br><br><br>\r\n    </div>\r\n    ");
                __builder2.AddMarkupContent(6, "<div>\r\n        <h3 style=\"font-weight:bold; color:black\">Login with your credentials</h3>\r\n    </div>\r\n    ");
                __builder2.AddMarkupContent(7, "<div>\r\n        <br>\r\n    </div>\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-6 row");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "class", "form-control col-6");
                __builder2.AddAttribute(13, "placeholder", "Employee ID");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
                                                 employee.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Id = __value, employee.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-6 row");
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "type", "password");
                __builder2.AddAttribute(23, "class", "form-control col-6");
                __builder2.AddAttribute(24, "placeholder", "Password");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
                                                                 employee.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Password = __value, employee.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(29, "<div class=\"col-12 row\">\r\n        <span class=\"col-12\"></span>\r\n        <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Login\">\r\n    </div>\r\n    <br>\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-12 row");
                __builder2.AddAttribute(32, "style", "text-align:left; font-weight:bold");
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "span");
                __builder2.AddAttribute(35, "class", "col-12");
                __builder2.AddContent(36, 
#nullable restore
#line 38 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
                              LoginMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Tonth\source\repos\T16_Project\Team16Project\Pages\Login.razor"
       
    private Employee employee;
    public string LoginMessage { get; set; }

    bool isBusy = false;
    string message = string.Empty;

    protected async override Task OnInitializedAsync()
    {
        employee = new Employee();

    }

    private async Task<bool> ValidateLogin()
    {
        string query = "SELECT staff_id, password FROM STAFF WHERE staff_id = @employee.Id AND password = @employee.password";

        
        return await Task.FromResult(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591