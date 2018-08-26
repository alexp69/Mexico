using System;
using System.Collections.Generic;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace mexico.Views
{
    public partial class Mapa : ContentPage,  INavigatedAware
    {
        public Mapa()
        {
            InitializeComponent();

           
       
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            var estado = parameters["estado"];
            SetMap(estado.ToString());
        }

        private async void SetMap(string estado)
        {
            Position position = new Position(0, 0);
            Geocoder geocoder = new Geocoder();
            var locations = await geocoder.GetPositionsForAddressAsync(estado);


            foreach (var p in locations)
            {
                position = new Position(p.Latitude, p.Longitude);
                break;
            }
            var pin = new Pin()
            {
                Position = position,
                Label = estado
            };

            MapView.Pins.Add(pin);
            MapView.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(20)));

        }
        private void Street_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Street;
        }



        private void Hybrid_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Hybrid;
        }

        private void Satellite_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Satellite;
        }

    }
}
