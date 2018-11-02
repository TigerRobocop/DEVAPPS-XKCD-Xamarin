using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DEVAPPS_Xamarin.iOS.DBPath))]
namespace DEVAPPS_Xamarin.iOS
{
    public class DBPath : IDBPath
    {
        public string GetPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "DB.db3");
        }
    }
}
