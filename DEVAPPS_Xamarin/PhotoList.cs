using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DEVAPPS_Xamarin
{
    [DataContract]
    public class PhotoList
    {
        [DataMember(Name = "photos")]
        public List<string> photos;
    }
}
