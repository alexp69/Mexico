using System;
using System.Windows.Input;
using mexico.Models;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace mexico.ViewModels
{
    public class LoginViewModel
    {
        INavigationService _navigationService;
        public DelegateCommand NavigateToEstados { get; set; } 

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToEstados = new DelegateCommand(NavigateToEstadosCall);


      
        }

   
        public async void NavigateToEstadosCall()
        {
            var loading = DependencyService.Get<ILoadingService>();
            loading.Show("Cargando Estados");

            await _navigationService.NavigateAsync("Estados");
            loading.Hide();
        }

    }
}