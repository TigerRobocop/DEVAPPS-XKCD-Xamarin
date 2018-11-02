using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DEVAPPS_Xamarin
{
    [DataContract]
    public class XKCD
    {
        [DataMember(Name = "month")]
        public string month;

        [DataMember(Name = "num")]
        public string num;

        [DataMember(Name = "link")]
        public string link;

        [DataMember(Name = "year")]
        public string year;

        [DataMember(Name = "news")]
        public string news;

        [DataMember(Name = "safe_title")]
        public string safe_title;

        [DataMember(Name = "transcript")]
        public string trasncript;

        [DataMember(Name = "alt")]
        public string alt;

        [DataMember(Name = "title")]
        public string title;

        [DataMember(Name = "img")]
        public string img;

        [DataMember(Name = "day")]
        public string day;
    }
}
