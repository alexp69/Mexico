using System;
using System.Collections.Generic;
using System.Windows.Input;
using mexico.Models;
using Prism.Navigation;
using Xamarin.Forms;
using mexico.Services;
using Prism.Commands;
using Realms;

namespace mexico.ViewModels
{
    public class EstadosViewModel
    {
        INavigationService _navigationService;
        public DelegateCommand ItemTappedCommand { get; set; }

        private List<Estado> _estados = new List<Estado>();
        public List<Estado> estados { get { return _estados; } set { _estados = value; } }

        private Estado _selectedEstado = new Estado();
        public Estado selectedEstado { get { return _selectedEstado; } set { _selectedEstado = value; } }



        public EstadosViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ItemTappedCommand = new DelegateCommand(OnItemTappedCommandExecuted);

          

            CargaEstados();
           
        }

    

        public void CargaEstados()
        {
            EstadosService servicio = new EstadosService();

            estados = servicio.GetAllEstados();
        }

        public void OnItemTappedCommandExecuted()
        {
            var estado = selectedEstado.name + ", México";
            _navigationService.NavigateAsync("Mapa?estado=" + estado);
        }
  
    }
}