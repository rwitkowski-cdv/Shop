using Microsoft.JSInterop;

namespace Shop.Extensions
{
    public static class IJSNotificationExtension
    {
        public static async Task ShowSuccessNotification(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async Task ShowErrorNotification(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}
