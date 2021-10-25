﻿
using BlazorWithIdentity.Client.Services.Implementations.ToastNotification;
using Microsoft.AspNetCore.Components;
using System;

namespace BlazorWithIdentity.Client.Shared
{
    public class ToastBase : ComponentBase, IDisposable
    {
        [Inject] ToastService ToastService { get; set; }

        protected string Heading { get; set; }
        protected string Message { get; set; }
        protected bool IsVisible { get; set; }
        protected string BackgroundCssClass { get; set; }
        protected string IconCssClass { get; set; }

        protected override void OnInitialized()
        {
            ToastService.OnShow += ShowToast;
            ToastService.OnHide += HideToast;
        }

        private void ShowToast(string message, ToastLevel level)
        {
            BuildToastSettings(level, message);
            IsVisible = true;
            StateHasChanged();
        }

        private void HideToast()
        {
            IsVisible = false;
            StateHasChanged();
        }

        private void BuildToastSettings(ToastLevel level, string message)
        {
            switch (level)
            {
                case ToastLevel.Info:
                    BackgroundCssClass = $"brand-info";
                    IconCssClass = "info";
                    Heading = "Info";
                    break;
                case ToastLevel.Success:
                    BackgroundCssClass = $"brand-success";
                    IconCssClass = "check";
                    Heading = "Success";
                    break;
                case ToastLevel.Warning:
                    BackgroundCssClass = $"brand-warning";
                    IconCssClass = "exclamation";
                    Heading = "Warning";
                    break;
                case ToastLevel.Error:
                    BackgroundCssClass = "brand-danger";
                    IconCssClass = "times";
                    Heading = "Error";
                    break;
            }

            Message = message;
        }

        public void Dispose()
        {
            ToastService.OnShow -= ShowToast;
        }
    }
}