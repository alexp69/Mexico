using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace mexico.ViewModels
{
    public class MapaViewModel
    {
        INavigationService _navigationService;
        public DelegateCommand NavigateToEstados { get; set; }

        public MapaViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToEstados = new DelegateCommand(NavigateToEstadosCall);
        }


        public void NavigateToEstadosCall()
        {
            _navigationService.GoBackAsync();
        }

    }
}