using System;
using AndroidHUD;
using mexico.Droid;
using mexico.Models;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(LoadingService))]
namespace mexico.Droid
{
    public class LoadingService: ILoadingService
    {
        public LoadingService()
        {
        }



        public void Show(string message = "")
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                AndHUD.Shared.Show(Forms.Context, message, maskType: MaskType.Black);
            });
        }

        public void Hide()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                AndHUD.Shared.Dismiss(Forms.Context);
            });
        }

    }
}
