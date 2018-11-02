using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace DEVAPPS_Xamarin
{
    public partial class Daily : ContentPage
    {
        WebRequest request;
        XKCD dailyImage;

        public Daily()
        {
            InitializeComponent();
            LoadImage();
        }

        void LoadImage() {
            Uri uri = new Uri("https://xkcd.com/info.0.json");
            request = WebRequest.Create(uri);

            lblLoading.Text = "lblLoading...";

            request.BeginGetResponse(HandleAsyncCallback, null);
        }

        void BtnReload_Clicked(object sender, System.EventArgs e)
        {
            imgDaily.Source = "";
            lblTitle.Text = "";
            LoadImage();
        }

        void BtnAdd_Clicked(object sender, System.EventArgs e)
        {
            var data = App.DB.Table<XKCD>();
            List<XKCD> result = (from p in data
                                 where p.num == dailyImage.num
                                 select p).ToList();

            if (result.Count > 0) {
                DisplayAlert("Save", "Already favorited", "OK");
            } else {

                App.DB.Insert(dailyImage);
                DisplayAlert("Save", "Favorited!", "OK");
            }
        }

        void HandleAsyncCallback(IAsyncResult ar)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Stream stream = request.EndGetResponse(ar).GetResponseStream();
                DataContractJsonSerializer serializer =
                    new DataContractJsonSerializer(typeof(XKCD));

                dailyImage = (XKCD)serializer.ReadObject(stream);
                imgDaily.Source = dailyImage.img;
                lblTitle.Text = dailyImage.title;

                lblLoading.Text = "";
            });
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(dailyImage.alt)) 
                DisplayAlert("Alt", dailyImage.alt, "OK");
        }
    }
}
