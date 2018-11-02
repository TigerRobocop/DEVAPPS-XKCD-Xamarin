using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DEVAPPS_Xamarin.Droid.DBPath))]
namespace DEVAPPS_Xamarin.Droid
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
