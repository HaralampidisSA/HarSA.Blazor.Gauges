using System.Text.Json.Serialization;

namespace HarSA.Blazor.Gauges.Configurations
{
    public class GaugeConfig
    {
        [JsonPropertyName("size")]
        public int? Size { get; set; }

        [JsonPropertyName("min")]
        public double? Min { get; set; }

        [JsonPropertyName("max")]
        public double? Max { get; set; }

        [JsonPropertyName("majorTicks")]
        public int? MajorTicks { get; set; }

        [JsonPropertyName("minorTicks")]
        public int? MinorTicks { get; set; }

        [JsonPropertyName("transitionDuration")]
        public int? TransitionDurationMs { get; set; }

        [JsonPropertyName("greenColor")]
        public string GreenColor { get; set; }

        [JsonPropertyName("yellowColor")]
        public string YellowColor { get; set; }

        [JsonPropertyName("redColor")]
        public string RedColor { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("yellowZone")]
        public GaugeZone YellowZone { get; set; } = new GaugeZone();

        [JsonPropertyName("greenZone")]
        public GaugeZone GreenZone { get; set; } = new GaugeZone();

        [JsonPropertyName("redZone")]
        public GaugeZone RedZone { get; set; } = new GaugeZone();

        [JsonPropertyName("valuePrecision")]
        public int? ValuePrecision { get; set; }

    }
}
