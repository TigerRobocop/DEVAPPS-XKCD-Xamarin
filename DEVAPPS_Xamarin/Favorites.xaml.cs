using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DEVAPPS_Xamarin
{
    public partial class Favorites : ContentPage
    {
        public Favorites()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            LoadList();
        }

        void LoadList(){
            var data = App.DB.Table<XKCD>();
            List<XKCD> result = (from p in data
                                   orderby p.num
                                   select p).ToList();

            listFavorites.ItemsSource = result;
        }
    }
}
