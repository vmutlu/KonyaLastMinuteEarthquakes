using Newtonsoft.Json;

namespace KonyaSonDakikaDepremleri.Models
{
    public class Deprem
    {
        [JsonProperty(PropertyName = "Id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "Tarih")]
        public string Tarih { get; set; }
        [JsonProperty(PropertyName = "Saat")]
        public string Saat { get; set; }
        [JsonProperty(PropertyName = "Unix_Time")]
        public string Unix_Time { get; set; }
        [JsonProperty(PropertyName = "Enlem(N)")]
        public string Enlem { get; set; }
        [JsonProperty(PropertyName = "Boylam(E)")]
        public string Boylam { get; set; }
        [JsonProperty(PropertyName = "Derinlik(km)")]
        public string Derinlik { get; set; }
        [JsonProperty(PropertyName = "Buyukluk")]
        public Buyukluk Buyukluk { get; set; }
        [JsonProperty(PropertyName = "Yer")]
        public string Yer { get; set; }
        [JsonProperty(PropertyName = "Nitelik")]
        public string Nitelik { get; set; }
    }
}
