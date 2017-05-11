using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GurCodesIntro
{
    public partial class Tab2Page : ContentPage
    {
        public Tab2Page()
        {
            InitializeComponent();

            MyListView.ItemsSource = new List<string>
            {
                "First",
                "Second",
                "Foo",
                "Unicorn"
            };
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Button clicked", "Hello World!", "OK");
        }
    }
}
