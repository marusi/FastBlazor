#pragma checksum "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b012b0a656922cc8b4aa5dfedfa918a0a5cb57"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWithIdentity.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using BlazorWithIdentity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using BlazorWithIdentity.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using BlazorWithIdentity.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using BlazorWithIdentity.Client.Services.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using BlazorWithIdentity.Client.Services.Implementations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using BlazorWithIdentity.Client.Services.Implementations.ToastNotification;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using BlazorWithIdentity.Client.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\MainLayout.razor"
using Microsoft.Fast.Components.FluentUI;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "row-sm");
                __builder2.AddAttribute(4, "b-07g7jfs9u7");
                __builder2.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>(5);
                __builder2.AddAttribute(6, "fill-color", "#2A1B3D");
                __builder2.AddAttribute(7, "style", "padding:10px;min-width:100%");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentToolbar>(9);
                    __builder3.AddAttribute(10, "id", "toolbar-fluent-components-main");
                    __builder3.AddAttribute(11, "style", "width:100%");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(13);
                        __builder4.AddAttribute(14, "Href", "/");
                        __builder4.AddAttribute(15, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 13 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\MainLayout.razor"
                                                                  Appearance.Outline

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(17, "Home");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(18, "\r\n                           ");
                        __builder4.OpenElement(19, "h5");
                        __builder4.AddAttribute(20, "slot", "end");
                        __builder4.AddAttribute(21, "b-07g7jfs9u7");
                        __builder4.AddContent(22, "Hi, ");
#nullable restore
#line 14 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\MainLayout.razor"
__builder4.AddContent(23, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(24, "  ");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentCheckbox>(25);
                        __builder4.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\MainLayout.razor"
                                                                                                       LogoutClick

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "slot", "end");
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(29, "Log out");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n      ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "row");
                __builder2.AddAttribute(33, "b-07g7jfs9u7");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-4 ");
                __builder2.AddAttribute(36, "b-07g7jfs9u7");
                __builder2.OpenComponent<BlazorWithIdentity.Client.Shared.NavMenu>(37);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-md-20");
                __builder2.AddAttribute(41, "b-07g7jfs9u7");
                __builder2.OpenComponent<BlazorWithIdentity.Client.Shared.Toast>(42);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n             ");
#nullable restore
#line 30 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\MainLayout.razor"
__builder2.AddContent(44, Body);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        \r\n     \r\n\r\n              \r\n           \r\n       \r\n\r\n              \r\n            \r\n      ");
                __builder2.OpenComponent<BlazorWithIdentity.Client.Shared.Footer>(46);
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(47, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 48 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\MainLayout.razor"
__builder2.AddContent(48, Body);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\MainLayout.razor"
      

    async Task LogoutClick()
    {
        await authStateProvider.Logout();
        navigationManager.NavigateTo("/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService toastService { get; set; }
    }
}
#pragma warning restore 1591
