#pragma checksum "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ddd83c0dce9b73bcfbe42c14684a3ccd42fbd5"
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
#line 7 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
using BlazorWithIdentity.Shared.DTO.Option;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
using BlazorWithIdentity.Shared.DTO.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/option")]
    public partial class Option : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-12");
            __builder.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentCard>(4);
            __builder.AddAttribute(5, "style", "height:50%");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 21 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
       if (options == null)
         {
            

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(7, "<ol class=\"list-items\"><li class=\"list-items-row\"><div class=\"row\"><div class=\"col-md-24\"><h6>Nothing to display</h6></div></div></li></ol>");
#nullable restore
#line 29 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
               
          }
        
         else
         {
            

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "ol");
                __builder2.AddAttribute(9, "class", "list-items");
                __builder2.OpenElement(10, "li");
                __builder2.AddAttribute(11, "class", "list-items-row");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(14);
                __builder2.AddAttribute(15, "class", "form-category");
                __builder2.AddAttribute(16, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 38 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                             OnSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 38 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                                              saveOptionDTO

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "col-md-12");
                    __builder3.AddMarkupContent(21, "<h6>Choose Category</h6>\r\n                                               ");
                    __Blazor.BlazorWithIdentity.Client.Pages.Option.TypeInference.CreateInputSelect_0(__builder3, 22, 23, "form-control", 24, "product", 25, 
#nullable restore
#line 41 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                                                            saveOptionDTO.ProductId

#line default
#line hidden
#nullable disable
                    , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => saveOptionDTO.ProductId = __value, saveOptionDTO.ProductId)), 27, () => saveOptionDTO.ProductId, 28, (__builder4) => {
#nullable restore
#line 43 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                     foreach (var item in products)
                                                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(29, "option");
                        __builder4.AddAttribute(30, "value", 
#nullable restore
#line 45 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                        item.Id

#line default
#line hidden
#nullable disable
                        );
#nullable restore
#line 45 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
__builder4.AddContent(31, item.ProductName);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 46 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                    }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.AddMarkupContent(32, "\r\n                                              <br>\r\n                                                   \r\n                                                        ");
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentTextField>(33);
                    __builder3.AddAttribute(34, "id", "inputCategory");
                    __builder3.AddAttribute(35, "placeholder", "New Option");
                    __builder3.AddAttribute(36, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                                                          saveOptionDTO.OptionName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => saveOptionDTO.OptionName = __value, saveOptionDTO.OptionName))));
                    __builder3.AddAttribute(38, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => saveOptionDTO.OptionName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                                                            ");
                    __Blazor.BlazorWithIdentity.Client.Pages.Option.TypeInference.CreateValidationMessage_1(__builder3, 40, 41, "text-danger", 42, 
#nullable restore
#line 51 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                                                          () => saveOptionDTO.OptionName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n                                                     ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "col-md-12");
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentButton>(46);
                    __builder3.AddAttribute(47, "type", "submit");
                    __builder3.AddAttribute(48, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 55 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                                                Appearance.Accent

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(50, "Submit");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n                                                    \r\n                                                      ");
                    __builder3.OpenElement(52, "label");
                    __builder3.AddAttribute(53, "class", "text-danger");
#nullable restore
#line 57 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
__builder3.AddContent(54, error);

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
#nullable restore
#line 63 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                       foreach (var item in options)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(55, "li");
                __builder2.AddAttribute(56, "class", "list-items-row");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "row");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-16");
                __builder2.OpenElement(61, "ol");
                __builder2.AddAttribute(62, "class", "breadcrumb");
                __builder2.OpenElement(63, "li");
                __builder2.OpenElement(64, "a");
                __builder2.AddAttribute(65, "href", "productdata/" + (
#nullable restore
#line 69 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                item.Product.Id

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 69 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
__builder2.AddContent(66, item.Product.ProductName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                      ");
                __builder2.OpenElement(68, "li");
                __builder2.AddAttribute(69, "class", "active");
#nullable restore
#line 70 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
__builder2.AddContent(70, item.OptionName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n               \r\n                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-md-4");
                __builder2.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(74);
                __builder2.AddAttribute(75, "Href", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                 $"optiondata/{item.Id}"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 76 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                                       Appearance.Stealth

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "<span style=\"color:green;\" class=\"glyph glyph-edit\"></span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                 ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-md-4");
                __builder2.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentButton>(82);
                __builder2.AddAttribute(83, "type", "submit");
                __builder2.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                            (() => DeleteOption(item.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 80 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
                                                                                                       Appearance.Stealth

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(87, "<span style=\"color:red;\" class=\"glyph glyph-delete\"></span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 84 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 86 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"

}

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n     <div class=\"col-md-12\"></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
      

    // private SuccessNotification _notification;

     [Parameter]
    public int Id { get; set; }
    SaveOptionDTO saveOptionDTO { get; set; } = new SaveOptionDTO();
    string error { get; set; }

    OptionDTO optionDTO { get; set; } = new OptionDTO();
  //  ProductCategoryDTO productCategoryDTO { get; set; } = new ProductCategoryDTO();
   
     [Inject]
    public IOptionDataService OptionDataService { get; set; }

      [Inject]
    public IProductDataService ProductDataService { get; set; }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await OptionDataService.CreateOption(saveOptionDTO);
            toastService.ShowToast($"{saveOptionDTO.OptionName} added Succesfuly", ToastLevel.Success);
            StateHasChanged();
             await OnInitializedAsync();
            navigationManager.NavigateTo("/option");
            
           

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
#line 136 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Option.razor"
              


        private OptionDTO[] options { get; set; }
        private ProductDTO[] products { get; set; }


    protected override async Task OnInitializedAsync()
    {
       products = await ProductDataService.GetProducts();
       options = await OptionDataService.GetOptions();


      // toastService.ShowToast($"Items loaded succesfuly", ToastLevel.Info);
    }

    protected async Task DeleteOption(int Id)
        {
          await OptionDataService.DeleteOption(Id);
          toastService.ShowToast($"Item deleted succesfuly", ToastLevel.Success);
            StateHasChanged();
            await OnInitializedAsync();
            //  StatusClass = "alert-success";
          //  Message = "Deleted successfully";

           // Saved = true;
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
namespace __Blazor.BlazorWithIdentity.Client.Pages.Option
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
