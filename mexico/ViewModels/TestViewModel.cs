using System;
using System.Windows.Input;
using mexico.Models;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace mexico.ViewModels
{
    public class TestViewModel
    {
        INavigationService _navigationService;

        public TestViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;


      
        }

   
    }
}