#pragma checksum "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94fa198e82987df1caf0ab6c7a54227d33f1b8c0"
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
#line 7 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
using BlazorWithIdentity.Shared.DTO.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Category")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Category/{Id:int}")]
    public partial class Category : Microsoft.AspNetCore.Components.ComponentBase
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
#line 22 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
       if (categories == null)
         {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(7, "<ol class=\"list-items\"><li class=\"list-items-row\"><div class=\"row\"><div class=\"col-md-24\"><h6>Nothing to display</h6></div></div></li></ol>");
#nullable restore
#line 29 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
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
#line 36 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                                 OnSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                                                  saveProductCategoryDTO

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "col-md-12");
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentTextField>(21);
                    __builder3.AddAttribute(22, "id", "inputCategory");
                    __builder3.AddAttribute(23, "placeholder", "New Category");
                    __builder3.AddAttribute(24, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                         saveProductCategoryDTO.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => saveProductCategoryDTO.Name = __value, saveProductCategoryDTO.Name))));
                    __builder3.AddAttribute(26, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => saveProductCategoryDTO.Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n         ");
                    __Blazor.BlazorWithIdentity.Client.Pages.Category.TypeInference.CreateValidationMessage_0(__builder3, 28, 29, "text-danger", 30, 
#nullable restore
#line 41 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                       () => saveProductCategoryDTO.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\r\n\r\n        ");
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "class", "col-md-12");
                    __builder3.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentButton>(34);
                    __builder3.AddAttribute(35, "type", "submit");
                    __builder3.AddAttribute(36, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 45 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                Appearance.Accent

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(38, "Submit");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.OpenElement(40, "label");
                    __builder3.AddAttribute(41, "class", "text-danger");
#nullable restore
#line 46 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
__builder3.AddContent(42, error);

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
#line 55 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
        foreach (var item in categories)
       {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(43, "li");
                __builder2.AddAttribute(44, "class", "list-items-row");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "row");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-md-16");
#nullable restore
#line 63 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
__builder2.AddContent(49, item.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n               \r\n                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-md-4");
                __builder2.OpenComponent<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>(53);
                __builder2.AddAttribute(54, "Href", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                 $"categorydata/{item.Id}"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 67 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                                                         Appearance.Stealth

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(57, "<span style=\"color:green;\" class=\"glyph glyph-edit\"></span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                 ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-4");
                __builder2.OpenComponent<Microsoft.Fast.Components.FluentUI.FluentButton>(61);
                __builder2.AddAttribute(62, "type", "submit");
                __builder2.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                            (() => DeleteCategory(item.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "Appearance", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.Fast.Components.FluentUI.Appearance?>(
#nullable restore
#line 71 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
                                                                                                         Appearance.Stealth

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "<span style=\"color:red;\" class=\"glyph glyph-delete\"></span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 75 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 77 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n   <div class=\"col-md-12\"></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
      

    // private SuccessNotification _notification;

     [Parameter]
    public int Id { get; set; }
    SaveProductCategoryDTO saveProductCategoryDTO { get; set; } = new SaveProductCategoryDTO();
    string error { get; set; }

    ProductCategoryDTO productCategoryDTO { get; set; } = new ProductCategoryDTO();
   
     [Inject]
    public ICategoryDataService CategoryDataService { get; set; }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await CategoryDataService.CreateCategory(saveProductCategoryDTO);
            toastService.ShowToast($"{saveProductCategoryDTO.Name} added Succesfuly", ToastLevel.Success);
            StateHasChanged();
             await OnInitializedAsync();
            navigationManager.NavigateTo("/category");
            
           

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
#line 147 "C:\Users\Hp\Desktop\dddEven\TwoTouch\BlazorWithIdentity\src\BlazorWithIdentity.Client\Pages\Category.razor"
              


    private ProductCategoryDTO[] categories { get; set; }
   

    protected override async Task OnInitializedAsync()
    {
       categories = await CategoryDataService.GetCategories();
      // toastService.ShowToast($"Items loaded succesfuly", ToastLevel.Info);
    }

    protected async Task DeleteCategory(int Id)
        {
          await CategoryDataService.DeleteCategory(Id);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService toastService { get; set; }
    }
}
namespace __Blazor.BlazorWithIdentity.Client.Pages.Category
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
