using BlazorWithIdentity.Client.Services.Implementations.ToastNotification;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Fast.Components.FluentUI;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Client.Shared
{
    public partial class MainLayout
    {
        // [Inject] IJSRuntime? JSRuntime { get; set; }

        //ErrorBoundary? errorBoundary;
        FluentDesignSystemProvider fdsp = new();
        LocalizationDirection? dir;
        float? baseLayerLuminance;

        public void SwitchTheme()
        {
            baseLayerLuminance = baseLayerLuminance == 0 ? 1 : 0;
        }

        protected override void OnParametersSet()
        {
           // errorBoundary?.Recover();
        }

      
        async Task LogoutClick()
        {
            await authStateProvider.Logout();
            toastService.ShowToast("Logged out!", ToastLevel.Info);
            navigationManager.NavigateTo("/login");
        }
    }
}
