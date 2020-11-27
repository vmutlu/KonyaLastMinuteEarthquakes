using Newtonsoft.Json;

namespace KonyaSonDakikaDepremleri.Models
{
    public class Buyukluk
    {
        [JsonProperty(PropertyName = "MD")]
        public double MD { get; set; }
        [JsonProperty(PropertyName = "ML")]
        public double ML { get; set; }
        [JsonProperty(PropertyName = "Mw")]
        public double Mw { get; set; }
    }
}
