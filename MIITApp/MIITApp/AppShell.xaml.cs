
using MIITApp.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace MIITApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Calendar1), typeof(Calendar1));
            Routing.RegisterRoute(nameof(Filter), typeof(Filter));

        }

    }
}
