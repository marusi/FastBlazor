#pragma checksum "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f162d221eaacd4881c3f98604bfa683d7a4b819b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWithIdentity.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
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
#line 18 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.Fast.Components.FluentUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
using BlazorWithIdentity.Shared.DTO.ProductSku;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
using BlazorWithIdentity.Shared.DTO.SkuValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productskudata/{Id:int}")]
    public partial class ProductSkuData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, "<h6>Price </h6>\r\n   ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-12");
            __builder.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentCard>(7);
            __builder.AddAttribute(8, "style", "height:50%");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 22 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
       if (productSkus == null)
         {
            

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(10, "<ol class=\"list-items\"><li class=\"list-items-row\"><div class=\"row\"><div class=\"col-md-24\"><h6>Nothing to display</h6></div></div></li></ol>");
#nullable restore
#line 30 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
               
          }
        
         else
         {
            

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(11, "ol");
                __builder2.AddAttribute(12, "class", "list-items");
                __builder2.OpenElement(13, "li");
                __builder2.AddAttribute(14, "class", "list-items-row");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(17);
                __builder2.AddAttribute(18, "class", "form-category");
                __builder2.AddAttribute(19, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 39 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
                                                                             OnSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 39 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
                                                                                              saveProductSkuDTO

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-24");
                    __builder3.OpenElement(24, "div");
                    __builder3.AddAttribute(25, "class", "col-md-12");
                    __builder3.AddMarkupContent(26, "<p>Choose Category</p>\r\n                                               ");
                    __Blazor.BlazorWithIdentity.Client.Pages.ProductSkuData.TypeInference.CreateInputSelect_0(__builder3, 27, 28, "form-control", 29, "optionValue", 30, 
#nullable restore
#line 43 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
                                                                                                                saveProductSkuDTO.SkuValueId

#line default
#line hidden
#nullable disable
                    , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => saveProductSkuDTO.SkuValueId = __value, saveProductSkuDTO.SkuValueId)), 32, () => saveProductSkuDTO.SkuValueId, 33, (__builder4) => {
#nullable restore
#line 45 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
                                                     foreach (var item in skuValues)
                                                    {
                                                       
                                                      

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(34, "option");
                        __builder4.AddAttribute(35, "value", 
#nullable restore
#line 49 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
                                                                     item.Id

#line default
#line hidden
#nullable disable
                        );
#nullable restore
#line 50 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
__builder4.AddContent(36, item.OptionValue.Option.Product.ProductName);

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(37, "\r\n                                                         ");
#nullable restore
#line 51 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
__builder4.AddContent(38, item.OptionValue.OptionValueName);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(39, "  ");
#nullable restore
#line 51 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
__builder4.AddContent(40, item.SkuValueName);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 54 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"

                                                     
                                                }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.AddMarkupContent(41, "\r\n                                               \r\n                                                <br>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n                                      <div class=\"col-md-12\"></div>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, " \r\n                                  \r\n                                  ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "col-md-12");
                    __builder3.OpenElement(46, "input");
                    __builder3.AddAttribute(47, "id", "inputCategory");
                    __builder3.AddAttribute(48, "type", "number");
                    __builder3.AddAttribute(49, "class", "form-control");
                    __builder3.AddAttribute(50, "placeholder", "New Price");
                    __builder3.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
                                                                                                                             saveProductSkuDTO.Price

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => saveProductSkuDTO.Price = __value, saveProductSkuDTO.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n                                                            ");
                    __Blazor.BlazorWithIdentity.Client.Pages.ProductSkuData.TypeInference.CreateValidationMessage_1(__builder3, 54, 55, "text-danger", 56, 
#nullable restore
#line 70 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
                                                                                                          () => saveProductSkuDTO.Price

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n                                                     ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "col-md-12");
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentButton>(60);
                    __builder3.AddAttribute(61, "type", "submit");
                    __builder3.AddAttribute(62, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 74 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
                                                                                                Appearance.Accent

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(64, "Submit");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n                                                    \r\n                                                      ");
                    __builder3.OpenElement(66, "label");
                    __builder3.AddAttribute(67, "class", "text-danger");
#nullable restore
#line 76 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
__builder3.AddContent(68, error);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                   \r\n                                <li class=\"list-items-row\"></li>");
                __builder2.CloseElement();
#nullable restore
#line 88 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"

}

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n     <div class=\"col-md-12\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
      

    // private SuccessNotification _notification;

     [Parameter]
    public int Id { get; set; }
    SaveProductSkuDTO saveProductSkuDTO { get; set; } = new SaveProductSkuDTO();
    string error { get; set; }

   
  //  ProductCategoryDTO productCategoryDTO { get; set; } = new ProductCategoryDTO();
   
     [Inject]
    public IProductSkuDataService ProductSkuDataService { get; set; }

      [Inject]
    public ISkuValueDataService SkuValueDataService { get; set; }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await ProductSkuDataService.UpdateProductSku(Id, saveProductSkuDTO);
            toastService.ShowToast($"{saveProductSkuDTO.Price} added Succesfuly", ToastLevel.Success);
            StateHasChanged();
             await OnInitializedAsync();
            navigationManager.NavigateTo("/productsku");
            
           

        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }
  

  

  

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\ProductSkuData.razor"
              


       private QueryResultDTO<ProductSkuDTO> productSkus { get; set; }
        private SkuValueDTO[] skuValues { get; set; }
        string empty;

    protected override async Task OnInitializedAsync()
    {
       productSkus = await ProductSkuDataService.GetProductSkus(empty);
       skuValues = await SkuValueDataService.GetSkuValues();


      // toastService.ShowToast($"Items loaded succesfuly", ToastLevel.Info);
    }

 

 
  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService toastService { get; set; }
    }
}
namespace __Blazor.BlazorWithIdentity.Client.Pages.ProductSkuData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591