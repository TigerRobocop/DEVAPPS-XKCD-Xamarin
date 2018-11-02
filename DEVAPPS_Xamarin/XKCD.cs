using System.Runtime.Serialization;
using SQLite;

namespace DEVAPPS_Xamarin
{
    [DataContract]
    [Table("XKCD")]
    public class XKCD
    {
        [Column("Id"), PrimaryKey(), AutoIncrement()]
        public int Id { get; set; }

        [DataMember(Name = "month")]
        [Column("month")]
        public string month { get; set; }

        [DataMember(Name = "num")]
        [Column("num")]
        public string num { get; set; }

        [DataMember(Name = "link")]
        [Column("link")]
        public string link { get; set; }

        [DataMember(Name = "year")]
        [Column("year")]
        public string year { get; set; }

        [DataMember(Name = "news")]
        [Column("news")]
        public string news { get; set; }

        [DataMember(Name = "safe_title")]
        [Column("safe_title")]
        public string safe_title { get; set; }

        [DataMember(Name = "transcript")]
        [Column("trasncript")]
        public string trasncript { get; set; }

        [DataMember(Name = "alt")]
        [Column("alt")]
        public string alt { get; set; }

        [DataMember(Name = "title")]
        [Column("title")]
        public string title { get; set; }

        [DataMember(Name = "img")]
        [Column("img")]
        public string img { get; set; }

        [DataMember(Name = "day")]
        [Column("day")]
        public string day { get; set; }
    }
}
