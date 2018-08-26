using System;
using BigTed;
using mexico.iOS;
using mexico.Models;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(LoadingService))]
namespace mexico.iOS
{

    public class LoadingService: ILoadingService
    {


        public LoadingService()
        {
            BTProgressHUD.ForceiOS6LookAndFeel = true;
        }


        public void Show(string message = "Cargando")
        {
            BTProgressHUD.Show(maskType: ProgressHUD.MaskType.Gradient, status: message);

        }

        public void Hide()
        {
            BTProgressHUD.Dismiss();
        }


    }
}
