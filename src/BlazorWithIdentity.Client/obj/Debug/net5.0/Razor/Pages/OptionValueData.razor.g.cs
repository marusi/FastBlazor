#pragma checksum "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "763d71b5b3b26c05e23e2d20d75c661cb9581242"
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
#nullable restore
#line 3 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
using BlazorWithIdentity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
using BlazorWithIdentity.Shared.DTO.Option;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
using BlazorWithIdentity.Shared.DTO.OptionValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/optionvaluedata/{Id:int}")]
    public partial class OptionValueData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "row row-sm");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "container");
                __builder2.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentCard>(6);
                __builder2.AddAttribute(7, "style", "height:25%");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
                    __builder3.AddAttribute(10, "class", "form-category");
                    __builder3.AddAttribute(11, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                OnSubmitOptionValue

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(12, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                                            saveOptionValueDTO

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.OpenElement(14, "div");
                        __builder4.AddAttribute(15, "class", "col-md-2");
                        __builder4.OpenElement(16, "fluent-anchor");
                        __builder4.AddAttribute(17, "Href", 
#nullable restore
#line 16 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                  $"option"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(18, "Appearance", "Appearance.Stealth");
                        __builder4.AddMarkupContent(19, "<span style=\"color:green;\" class=\"glyph glyph-back\"></span>");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(20, "\r\n         \r\n      ");
                        __builder4.OpenElement(21, "div");
                        __builder4.AddAttribute(22, "class", "col-md-6");
#nullable restore
#line 21 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
           if(options == null) 
          {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(23, "<p><a href=\"/options\">Insert</a> a new category </p>");
#nullable restore
#line 24 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
          } else {
             

#line default
#line hidden
#nullable disable
                        __Blazor.BlazorWithIdentity.Client.Pages.OptionValueData.TypeInference.CreateInputSelect_0(__builder4, 24, 25, "form-control", 26, "options", 27, 
#nullable restore
#line 26 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                                            saveOptionValueDTO.OptionId

#line default
#line hidden
#nullable disable
                        , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => saveOptionValueDTO.OptionId = __value, saveOptionValueDTO.OptionId)), 29, () => saveOptionValueDTO.OptionId, 30, (__builder5) => {
#nullable restore
#line 28 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                     foreach (var item in options)
                                                    {
                                                       

#line default
#line hidden
#nullable disable
                            __builder5.OpenElement(31, "option");
                            __builder5.AddAttribute(32, "value", 
#nullable restore
#line 31 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                                        item.Id

#line default
#line hidden
#nullable disable
                            );
#nullable restore
#line 31 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
__builder5.AddContent(33, item.OptionName);

#line default
#line hidden
#nullable disable
                            __builder5.CloseElement();
#nullable restore
#line 32 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                    }

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.AddMarkupContent(34, "\r\n                                                 ");
                        __builder4.AddMarkupContent(35, "<p>Option</p>");
#nullable restore
#line 35 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
           }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(36, "\r\n                ");
                        __builder4.OpenElement(37, "div");
                        __builder4.AddAttribute(38, "class", "col-md-8");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentTextField>(39);
                        __builder4.AddAttribute(40, "id", "inputCategory");
                        __builder4.AddAttribute(41, "placeholder", 
#nullable restore
#line 40 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                                                                                         optionValueItem.OptionValueName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(42, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                                      saveOptionValueDTO.OptionValueName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => saveOptionValueDTO.OptionValueName = __value, saveOptionValueDTO.OptionValueName))));
                        __builder4.AddAttribute(44, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => saveOptionValueDTO.OptionValueName));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                    ");
                        __Blazor.BlazorWithIdentity.Client.Pages.OptionValueData.TypeInference.CreateValidationMessage_1(__builder4, 46, 47, "text-danger", 48, 
#nullable restore
#line 41 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                                  () => saveOptionValueDTO.OptionValueName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(49, "\r\n\r\n                ");
                        __builder4.OpenElement(50, "div");
                        __builder4.AddAttribute(51, "class", "col-md-8");
                        __builder4.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentButton>(52);
                        __builder4.AddAttribute(53, "type", "submit");
                        __builder4.AddAttribute(54, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 47 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                                                            Appearance.Accent

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(56, "Submit");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n                    ");
                        __builder4.OpenElement(58, "label");
                        __builder4.AddAttribute(59, "class", "text-danger");
#nullable restore
#line 48 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
__builder4.AddContent(60, error);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
        [Parameter]
    public int Id { get; set; }
    string error { get; set; }


    OptionValueDTO optionValueItem { get; set; } = new OptionValueDTO();
    SaveOptionValueDTO saveOptionValueDTO { get; set; } = new SaveOptionValueDTO();





    [Inject]
    public IOptionValueDataService OptionValueDataService { get; set; }
    [Inject]
    public IOptionDataService OptionDataService { get; set; }

    async Task OnSubmitOptionValue()
    {
        error = null;
        try
        {
            await OptionValueDataService.UpdateOptionValue(Id, saveOptionValueDTO);
            toastService.ShowToast($"{saveOptionValueDTO.OptionValueName} added Succesfuly", ToastLevel.Success);
             StateHasChanged();
               await OnInitializedAsync();
            navigationManager.NavigateTo("/optionvalue");



        }
        catch (Exception ex)
        {
            error = ex.Message;
            toastService.ShowToast($"{saveOptionValueDTO.OptionValueName} failed to add", ToastLevel.Error);
        }
    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\OptionValueData.razor"
                
       private OptionDTO[] options { get; set; }
      protected override async Task OnInitializedAsync()
    {
          options = await OptionDataService.GetOptions();
            optionValueItem = await OptionValueDataService.GetOptionValueById(Id);
            
          // dataList = await CategoryDataService.GetCategories();
            // toastService.ShowToast($"Items loaded succesfuly", ToastLevel.Info);
    }

      
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ViewOptionService ViewOption { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService toastService { get; set; }
    }
}
namespace __Blazor.BlazorWithIdentity.Client.Pages.OptionValueData
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
