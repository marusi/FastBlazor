#pragma checksum "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37837a78ddd1e801aa585307d3e01e839fbbb55c"
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
using BlazorWithIdentity.Client.Services.Implementations.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using BlazorWithIdentity.Client.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.Fast.Components.FluentUI;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>(0);
            __builder.AddAttribute(1, "role", "navigation");
            __builder.AddAttribute(2, "class", "navigation");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentAccordion>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>(6);
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(8, "<span class=\"glyph glyph-edit\" slot=\"start\" b-234l2opi20></span>\r\n       \r\n        ");
                        __builder4.AddMarkupContent(9, "<span class=\"type-c1\" slot=\"heading\" b-234l2opi20>Update</span>\r\n        ");
                        __builder4.OpenElement(10, "ul");
                        __builder4.AddAttribute(11, "class", "list-items");
                        __builder4.AddAttribute(12, "b-234l2opi20");
                        __builder4.OpenElement(13, "li");
                        __builder4.AddAttribute(14, "class", "list-items-row");
                        __builder4.AddAttribute(15, "b-234l2opi20");
                        __builder4.OpenElement(16, "div");
                        __builder4.AddAttribute(17, "class", "row");
                        __builder4.AddAttribute(18, "b-234l2opi20");
                        __builder4.OpenElement(19, "div");
                        __builder4.AddAttribute(20, "class", "col-md-24");
                        __builder4.AddAttribute(21, "b-234l2opi20");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(22);
                        __builder4.AddAttribute(23, "Href", "/Category");
                        __builder4.AddAttribute(24, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 19 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor"
                                                                       Appearance.Stealth

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(26, "Category");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(27, "\r\n      ");
                        __builder4.OpenElement(28, "li");
                        __builder4.AddAttribute(29, "class", "list-items-row");
                        __builder4.AddAttribute(30, "b-234l2opi20");
                        __builder4.OpenElement(31, "div");
                        __builder4.AddAttribute(32, "class", "row");
                        __builder4.AddAttribute(33, "b-234l2opi20");
                        __builder4.OpenElement(34, "div");
                        __builder4.AddAttribute(35, "class", "col-md-24");
                        __builder4.AddAttribute(36, "b-234l2opi20");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(37);
                        __builder4.AddAttribute(38, "Href", "/product");
                        __builder4.AddAttribute(39, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 28 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor"
                                                                     Appearance.Stealth

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(41, "Product Name");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(42, "\r\n         ");
                        __builder4.OpenElement(43, "li");
                        __builder4.AddAttribute(44, "class", "list-items-row");
                        __builder4.AddAttribute(45, "b-234l2opi20");
                        __builder4.OpenElement(46, "div");
                        __builder4.AddAttribute(47, "class", "row");
                        __builder4.AddAttribute(48, "b-234l2opi20");
                        __builder4.OpenElement(49, "div");
                        __builder4.AddAttribute(50, "class", "col-md-24");
                        __builder4.AddAttribute(51, "b-234l2opi20");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(52);
                        __builder4.AddAttribute(53, "Href", "/option");
                        __builder4.AddAttribute(54, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 37 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor"
                                                                    Appearance.Stealth

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(56, "Option");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(57, " \r\n         ");
                        __builder4.OpenElement(58, "li");
                        __builder4.AddAttribute(59, "class", "list-items-row");
                        __builder4.AddAttribute(60, "b-234l2opi20");
                        __builder4.OpenElement(61, "div");
                        __builder4.AddAttribute(62, "class", "row");
                        __builder4.AddAttribute(63, "b-234l2opi20");
                        __builder4.OpenElement(64, "div");
                        __builder4.AddAttribute(65, "class", "col-md-24");
                        __builder4.AddAttribute(66, "b-234l2opi20");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(67);
                        __builder4.AddAttribute(68, "Href", "/optionvalue");
                        __builder4.AddAttribute(69, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 46 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor"
                                                                         Appearance.Stealth

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(71, "Option Value");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(72, " \r\n         ");
                        __builder4.OpenElement(73, "li");
                        __builder4.AddAttribute(74, "class", "list-items-row");
                        __builder4.AddAttribute(75, "b-234l2opi20");
                        __builder4.OpenElement(76, "div");
                        __builder4.AddAttribute(77, "class", "row");
                        __builder4.AddAttribute(78, "b-234l2opi20");
                        __builder4.OpenElement(79, "div");
                        __builder4.AddAttribute(80, "class", "col-md-24");
                        __builder4.AddAttribute(81, "b-234l2opi20");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(82);
                        __builder4.AddAttribute(83, "Href", "/skuvalue");
                        __builder4.AddAttribute(84, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 55 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor"
                                                                      Appearance.Stealth

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(86, "Sku Value");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(87, " \r\n\r\n         ");
                        __builder4.OpenElement(88, "li");
                        __builder4.AddAttribute(89, "class", "list-items-row");
                        __builder4.AddAttribute(90, "b-234l2opi20");
                        __builder4.OpenElement(91, "div");
                        __builder4.AddAttribute(92, "class", "row");
                        __builder4.AddAttribute(93, "b-234l2opi20");
                        __builder4.OpenElement(94, "div");
                        __builder4.AddAttribute(95, "class", "col-md-24");
                        __builder4.AddAttribute(96, "b-234l2opi20");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(97);
                        __builder4.AddAttribute(98, "Href", "/productsku");
                        __builder4.AddAttribute(99, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 65 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor"
                                                                        Appearance.Stealth

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(101, "Price");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n    ");
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>(103);
                    __builder3.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(105, "<span slot=\"start\" class=\"glyph glyph-list\" b-234l2opi20>List</span>\r\n        ");
                        __builder4.AddMarkupContent(106, "<span slot=\"heading\" b-234l2opi20>List</span>\r\n         ");
                        __builder4.OpenElement(107, "ul");
                        __builder4.AddAttribute(108, "class", "list-items");
                        __builder4.AddAttribute(109, "b-234l2opi20");
                        __builder4.OpenElement(110, "li");
                        __builder4.AddAttribute(111, "class", "list-items-row");
                        __builder4.AddAttribute(112, "b-234l2opi20");
                        __builder4.OpenElement(113, "div");
                        __builder4.AddAttribute(114, "class", "row");
                        __builder4.AddAttribute(115, "b-234l2opi20");
                        __builder4.OpenElement(116, "div");
                        __builder4.AddAttribute(117, "class", "col-md-24");
                        __builder4.AddAttribute(118, "b-234l2opi20");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentAnchor>(119);
                        __builder4.AddAttribute(120, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 80 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor"
                                           Appearance.Stealth

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(121, "Href", "/productlist");
                        __builder4.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(123, "Products List");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(124, "\r\n      ");
                        __builder4.OpenElement(125, "li");
                        __builder4.AddAttribute(126, "class", "list-items-row");
                        __builder4.AddAttribute(127, "b-234l2opi20");
                        __builder4.OpenElement(128, "div");
                        __builder4.AddAttribute(129, "class", "row");
                        __builder4.AddAttribute(130, "b-234l2opi20");
                        __builder4.OpenElement(131, "div");
                        __builder4.AddAttribute(132, "class", "col-md-24");
                        __builder4.AddAttribute(133, "b-234l2opi20");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentAnchor>(134);
                        __builder4.AddAttribute(135, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 89 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Shared\NavMenu.razor"
                                              Appearance.Stealth

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(136, "Href", "/composite");
                        __builder4.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(138, "Composite Products");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationmanager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ViewOptionService ViewOption { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService toastService { get; set; }
    }
}
#pragma warning restore 1591
