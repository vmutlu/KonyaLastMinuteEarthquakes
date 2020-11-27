using Newtonsoft.Json;
using System.Collections.Generic;

namespace KonyaSonDakikaDepremleri.Models
{
    public class DepremClass
    {
        [JsonProperty(PropertyName = "dev")]
        public string dev { get; set; }
        [JsonProperty(PropertyName = "source")]
        public string source { get; set; }
        [JsonProperty(PropertyName = "github_link")]
        public string github__link { get; set; }
        [JsonProperty(PropertyName = "depremler")]
        public List<Deprem> depremler { get; set; }
    }
}
