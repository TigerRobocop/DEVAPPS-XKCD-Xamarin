using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DEVAPPS_Xamarin
{
    public partial class Favorites : ContentPage
    {
        DB db;

        public Favorites()
        {
            InitializeComponent();
            db = new DB();
        }

        protected override void OnAppearing()
        {
            LoadList();
        }

        void LoadList(){
            listFavorites.ItemsSource = db.GetAll();
        }
    }
}
