using MIITApp.Models;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MIITApp.Views
{
    public partial class Audiences : ContentPage
    {
      
        public Audiences()
        {
            InitializeComponent();

         
        }

        

        private async void Calendar_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Calendar1));
        }

        private async void Filter_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Filter));
        }
    }
}