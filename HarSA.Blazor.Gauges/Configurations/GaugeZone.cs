using System.Text.Json.Serialization;

namespace HarSA.Blazor.Gauges.Configurations
{
    public class GaugeZone
    {
        [JsonPropertyName("from")]
        public double? From { get; set; }

        [JsonPropertyName("to")]
        public double? To { get; set; }
    }
}
