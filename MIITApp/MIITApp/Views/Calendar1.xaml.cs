
using System.ComponentModel;
using Xamarin.Forms;

namespace MIITApp.Views
{
    public partial class Calendar1 : ContentPage
    {
        public Calendar1()
        {
            InitializeComponent();
            
        }
        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (label != null)
                label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}