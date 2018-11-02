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
            LoadImage();
        }

        void BtnAdd_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        void HandleAsyncCallback(IAsyncResult ar)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Stream stream = request.EndGetResponse(ar).GetResponseStream();
                DataContractJsonSerializer serializer =
                    new DataContractJsonSerializer(typeof(XKCD));

                XKCD img = (XKCD)serializer.ReadObject(stream);
                imgDaily.Source = img.img;

                lblLoading.Text = "";
            });
        }
    }
}
