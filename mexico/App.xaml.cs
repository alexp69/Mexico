using System;
using Xamarin.Forms;
using mexico.Views;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using Prism.Ioc;
using Prism;
using mexico.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace mexico
{
    public partial class App : PrismApplication
    {

        public App(IPlatformInitializer initializer=null): base(initializer){} 


        protected override  void OnInitialized(){
        InitializeComponent();

            NavigationService.NavigateAsync("Login");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry){

            containerRegistry.RegisterForNavigation<Login, LoginViewModel>();
            containerRegistry.RegisterForNavigation<Estados, EstadosViewModel>();
            containerRegistry.RegisterForNavigation<Mapa, MapaViewModel>();
         

        }

    }
}
