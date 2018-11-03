using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;


namespace DEVAPPS_Xamarin
{
    public class DB
    {
        static SQLiteConnection _db;

        public static SQLiteConnection Conn 
        {
            get
            {
                if (_db is null)
                {
                    string path = DependencyService.Get<IDBPath>().GetPath();
                    _db = new SQLiteConnection(path);
                    _db.CreateTable<XKCD>();
                    return _db;
                }
                return _db;
            }
        }

        public bool IdExists(string id) {
            var data = DB.Conn.Table<XKCD>();
            List<XKCD> result = (from p in data
            where p.num == id
            select p).ToList();

            return result.Count > 0;
        }

        public void Save (XKCD dailyXKCD) {
            DB.Conn.Insert(dailyXKCD);
        }

        public List<XKCD> GetAll() {
            var data = DB.Conn.Table<XKCD>();
            List<XKCD> result = (from p in data
                                 orderby p.num
                                 select p).ToList();

            return result;
        }
    }
}
