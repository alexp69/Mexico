using System;
using System.Collections.Generic;
using mexico.Models;
using Xamarin.Forms;

namespace mexico.Views
{
    public partial class Estados : ContentPage
    {
        public Estados()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {

            base.OnAppearing();

        }
    }
}
