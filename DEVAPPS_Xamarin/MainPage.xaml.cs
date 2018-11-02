using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DEVAPPS_Xamarin
{
    public partial class MainPage : TabbedPage
    {
        //WebRequest request;

        public MainPage()
        {
            InitializeComponent();
            //Uri uri = new Uri("https://xkcd.com/info.0.json");
            //request = WebRequest.Create(uri);

            //lblLoading.Text = "lblLoading...";

            //request.BeginGetResponse(HandleAsyncCallback, null);
        }

        //void HandleAsyncCallback(IAsyncResult ar)
        //{
        //    Device.BeginInvokeOnMainThread(() =>
        //    {
        //        Stream stream = request.EndGetResponse(ar).GetResponseStream();
        //        DataContractJsonSerializer serializer =
        //            new DataContractJsonSerializer(typeof(XKCD));

        //        XKCD img = (XKCD)serializer.ReadObject(stream);
        //        imgDaily.Source = img.img;

        //        lblLoading.Text = "";
        //    });
        //}
    }
}
