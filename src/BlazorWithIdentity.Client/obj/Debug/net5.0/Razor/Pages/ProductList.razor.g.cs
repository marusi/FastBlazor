#pragma checksum "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5843cb66d2ca950b6cc606c37a6dadd6eaad4227"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWithIdentity.Client.Pages
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
#line 18 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.Fast.Components.FluentUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
using BlazorWithIdentity.Shared.DTO.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
using BlazorWithIdentity.Shared.DTO.CompositeProduct;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
using BlazorWithIdentity.Shared.DTO.ProductSku;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row row-sm");
            __builder.AddAttribute(2, "b-fajghabgcf");
            __builder.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>(3);
            __builder.AddAttribute(4, "fill-color", "#ffffff");
            __builder.AddAttribute(5, "style", "padding:10px;min-width:100%;position: sticky; ");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentToolbar>(7);
                __builder2.AddAttribute(8, "id", "toolbar-fluent-product-list");
                __builder2.AddAttribute(9, "style", "width:100%");
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "putbox");
                    __builder3.AddAttribute(13, "b-fajghabgcf");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "putbox-icon");
                    __builder3.AddAttribute(16, "b-fajghabgcf");
                    __builder3.OpenElement(17, "span");
                    __builder3.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                             Toggle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "class", "glyph glyph-checkbox-composite");
                    __builder3.AddAttribute(20, "b-fajghabgcf");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "putbox-content");
                    __builder3.AddAttribute(24, "b-fajghabgcf");
                    __builder3.AddMarkupContent(25, "<div class=\"content-title\" b-fajghabgcf>Filter products by category:</div>\r\n            ");
                    __builder3.OpenElement(26, "form");
                    __builder3.AddAttribute(27, "class", "content-form");
                    __builder3.AddAttribute(28, "b-fajghabgcf");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "combobox");
                    __builder3.AddAttribute(31, "b-fajghabgcf");
#nullable restore
#line 21 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                      if (categories == null)
                    {
                        
                    } else { 

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(32, "select");
                    __builder3.AddAttribute(33, "class", "form-control");
                    __builder3.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                                                OnFilterProducts

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                                                                           query.CategoryId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => query.CategoryId = __value, query.CategoryId));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.AddAttribute(37, "b-fajghabgcf");
                    __builder3.OpenElement(38, "option");
                    __builder3.AddAttribute(39, "value");
                    __builder3.AddAttribute(40, "b-fajghabgcf");
                    __builder3.AddContent(41, "All Products");
                    __builder3.CloseElement();
#nullable restore
#line 27 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                  foreach (var item in categories)
                  {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(42, "option");
                    __builder3.AddAttribute(43, "value", 
#nullable restore
#line 29 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                     item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(44, "b-fajghabgcf");
#nullable restore
#line 29 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
__builder3.AddContent(45, item.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 30 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                   }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 32 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"

          }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentButton>(47);
                    __builder3.AddAttribute(48, "slot", "end");
                    __builder3.AddAttribute(49, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 39 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                             Appearance.Accent

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "Disabled", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 39 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                                                           IsDisabled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
              (() => ListUpdated())

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(53, "Create Composite Selection");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n    \r\n    \r\n\r\n     ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-md-24");
            __builder.AddAttribute(57, "b-fajghabgcf");
            __builder.OpenElement(58, "ol");
            __builder.AddAttribute(59, "class", "list-items");
            __builder.AddAttribute(60, "b-fajghabgcf");
#nullable restore
#line 52 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
   if (productSkus == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "<li class=\"list-items-row\" b-fajghabgcf><fluent-progress-ring b-fajghabgcf></fluent-progress-ring></li>");
#nullable restore
#line 57 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
} else
{

      
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
     foreach (var item in productSkus.Items)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "li");
            __builder.AddAttribute(63, "class", "list-items-row");
            __builder.AddAttribute(64, "b-fajghabgcf");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.AddAttribute(67, "b-fajghabgcf");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-2");
            __builder.AddAttribute(70, "b-fajghabgcf");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "hidden", 
#nullable restore
#line 66 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                          HideLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(73, "b-fajghabgcf");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "checkbox");
            __builder.AddAttribute(76, "b-fajghabgcf");
            __builder.OpenElement(77, "label");
            __builder.AddAttribute(78, "b-fajghabgcf");
#nullable restore
#line 71 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                     if (@item.Id > 0)
                    {
                       

#line default
#line hidden
#nullable disable
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "name", "AreChecked");
            __builder.AddAttribute(81, "type", "checkbox");
            __builder.AddAttribute(82, "value", 
#nullable restore
#line 75 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                    item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                         eventArgs => { CheckChanged
                            (saveCompositeProductDTO, eventArgs.Value, item.Id, item.Price);
                            }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "b-fajghabgcf");
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                    }
                     else
                     {
                         

#line default
#line hidden
#nullable disable
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "name", "AreChecked");
            __builder.AddAttribute(87, "type", "checkbox");
            __builder.AddAttribute(88, "value", 
#nullable restore
#line 85 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                    item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(89, "checked");
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                       eventArgs => { CheckChanged 
                            (saveCompositeProductDTO, eventArgs.Value, item.Id,item.Price);}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "b-fajghabgcf");
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                     }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(92, "<span b-fajghabgcf></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n            ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "hidden", 
#nullable restore
#line 97 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                           !HideLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(96, "b-fajghabgcf");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-md-18");
            __builder.AddAttribute(100, "b-fajghabgcf");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "entity-list ");
            __builder.AddAttribute(103, "b-fajghabgcf");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "entity-list-item ");
            __builder.AddAttribute(106, "b-fajghabgcf");
            __builder.AddMarkupContent(107, "<div class=\"item-icon\" b-fajghabgcf><span class=\"glyph glyph-chevron-right\" b-fajghabgcf></span></div>\r\n          ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "item-content-secondary");
            __builder.AddAttribute(110, "b-fajghabgcf");
#nullable restore
#line 107 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
__builder.AddContent(111, item.SkuValue.SkuValueName);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(112, "\r\n              ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "content-text-tertiary ");
            __builder.AddAttribute(115, "b-fajghabgcf");
            __builder.OpenElement(116, "span");
            __builder.AddAttribute(117, "class", "label label-warning");
            __builder.AddAttribute(118, "b-fajghabgcf");
#nullable restore
#line 108 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
__builder.AddContent(119, item.SkuValue.OptionValue.Option.Product.ProductCategory.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\r\n          ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "item-content-primary");
            __builder.AddAttribute(123, "b-fajghabgcf");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "col-md-18");
            __builder.AddAttribute(126, "b-fajghabgcf");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "content-text-primary ");
            __builder.AddAttribute(129, "b-fajghabgcf");
#nullable restore
#line 115 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
__builder.AddContent(130, item.SkuValue.OptionValue.Option.Product.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n            ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "content-text-secondary");
            __builder.AddAttribute(134, "b-fajghabgcf");
#nullable restore
#line 116 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
__builder.AddContent(135, item.SkuValue.OptionValue.OptionValueName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(136, " - KES ");
#nullable restore
#line 116 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
__builder.AddContent(137, item.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n              ");
            __builder.AddMarkupContent(139, "<div class=\"col-md-6\" b-fajghabgcf><div class=\"content-text-tertiary \" b-fajghabgcf></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n      ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "col-md-4");
            __builder.AddAttribute(143, "b-fajghabgcf");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "col-md-12");
            __builder.AddAttribute(146, "b-fajghabgcf");
            __builder.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(147);
            __builder.AddAttribute(148, "Href", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 136 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                                 $"productskudata/{item.Id}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 136 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                                                                           Appearance.Stealth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(150, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(151, "<span style=\"color:green;\" class=\"glyph glyph-edit\" b-fajghabgcf></span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                 ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "col-md-12");
            __builder.AddAttribute(155, "b-fajghabgcf");
            __builder.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentButton>(156);
            __builder.AddAttribute(157, "type", "submit");
            __builder.AddAttribute(158, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 140 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                                            (() => DeleteProductSku(item.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(159, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 140 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                                                                                                           Appearance.Stealth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(160, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(161, "<span style=\"color:red;\" class=\"glyph glyph-delete\" b-fajghabgcf></span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 147 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(162, "<li b-fajghabgcf></li>");
#nullable restore
#line 154 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
   

}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
       

    ProductSkuDTO productSkuValueDTO { get; set; } = new ProductSkuDTO();
    ProductSkuQueryDTO query { get; set; } = new ProductSkuQueryDTO();

    protected bool IsDisabled = true;
    private bool HideLabel   = true;
    private void Toggle()
      {
         HideLabel =   !HideLabel;
      } 
    string error { get; set; }
     [Inject]
    public IProductSkuDataService ProductSkuDataService { get; set; }
    [Inject]
    public ICompositeProductDataService CompositeProductDataService { get; set; }

      [Inject]
    public ICategoryDataService CategoryDataService { get; set; }


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 198 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                

        // private ProductSkuDTO[] productSkus { get; set; }
        private QueryResultDTO<ProductSkuDTO> productSkus { get; set; }
        private ProductCategoryDTO[] categories { get; set; }

        [Parameter]
        public int Id { get; set; }

        SaveCompositeProductDTO saveCompositeProductDTO { get; set; } = new SaveCompositeProductDTO();
        string errorTwo { get; set; }
        protected override async Task OnInitializedAsync()
        {

            await   OnFilterProducts();
            categories = await CategoryDataService.GetCategories();




        }



        protected void CheckChanged(SaveCompositeProductDTO saveProduct,
                                     object checkValue, int id, decimal price)
        {

            int number = 0;
            if (id > number)
            {
                number = (int)id;
                // saveProduct = await CompositeProductDataService.CreateCompositeProduct(saveCompositeProductDTO);
                if((bool)checkValue)
                {
                  
                    saveCompositeProductDTO.CombinedProducts.Add(number);
                    saveCompositeProductDTO.CombinedProducts.ToList();
                    saveCompositeProductDTO.TotalPrice += price;
                    Console.WriteLine($"First total: {saveCompositeProductDTO.TotalPrice}");
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 238 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                     if (saveCompositeProductDTO.CombinedProducts.Count > 1)
                    {
                      IsDisabled = false;  
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 241 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                     


                    //  await CompositeProductDataService.CreateCompositeProduct(saveProduct);
                    //  toastService.ShowToast($"Product Created Succesfuly", ToastLevel.Success);
                } else 
                {
                    saveCompositeProductDTO.TotalPrice = saveCompositeProductDTO.TotalPrice - price;
                    saveCompositeProductDTO.CombinedProducts.Remove(number);
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 250 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                     if (saveCompositeProductDTO.CombinedProducts.Count < 2)
                    {
                      IsDisabled = true;  
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 253 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductList.razor"
                     
                    
                    Console.WriteLine($"Last total: {saveCompositeProductDTO.TotalPrice}");
                    
                    
                    
                }
            } else {
                    
            }

        }


        async Task ListUpdated()
        {
            await CompositeProductDataService.CreateCompositeProduct(saveCompositeProductDTO);
            toastService.ShowToast($"Products Created Succesfuly", ToastLevel.Success);
            saveCompositeProductDTO.CombinedProducts.Clear();

            saveCompositeProductDTO.TotalPrice = 0;
         
            navigationManager.NavigateTo("/composite");
        }
        private  async Task OnFilterProducts()
        {
              var props = GetProperties(query);
            foreach (var prop in props)
		{
                if (prop.Key != "CategoryId")
                {
                 // productSkus = await ProductSkuDataService.GetProductSkus("");  
                } else if (prop.Key == "CategoryId") {

                    var combined = $"{prop.Key}={prop.Value}";
                    productSkus = await ProductSkuDataService.GetProductSkus(combined);

                 //   await OnInitializedAsync();
                    // await OnFilterProducts();
                 
                 
                 } else if (prop.Key == "OptionValueId") {

                    var combined = $"{prop.Key}={prop.Value}";
                    productSkus = await ProductSkuDataService.GetProductSkus(combined);
                }
		}
        }

        private static Dictionary<string, string> GetProperties(object obj)
	{
		var props = new Dictionary<string, string>();
		if (obj == null)
			return props;

		var type = obj.GetType();
		foreach (var prop in type.GetProperties())
		{
			var val = prop.GetValue(obj, new object[] { });
			var valStr = val == null ? "" : val.ToString();
			props.Add(prop.Name, valStr);
		}

		return props;
	}


  protected async Task DeleteProductSku(int Id)
        {
          await ProductSkuDataService.DeleteProductSku(Id);
          toastService.ShowToast($"Item({Id}) deleted succesfuly", ToastLevel.Success);
            StateHasChanged();
            await OnInitializedAsync();
            //  StatusClass = "alert-success";
          //  Message = "Deleted successfully";

           // Saved = true;
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
