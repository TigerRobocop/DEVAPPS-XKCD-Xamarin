using System;

using Xamarin.Forms;

namespace DEVAPPS_Xamarin
{
    public class Favorites : ContentPage
    {
        public Favorites()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

