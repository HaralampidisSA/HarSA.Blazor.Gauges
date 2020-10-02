using HarSA.Blazor.Gauges.Components;
using HarSA.Blazor.Gauges.Configurations;
using System;
using System.Threading.Tasks;

namespace HarSA.Blazor.Gauges.BlazorClient.Pages
{
    public partial class Gauges
    {
        private GaugeConfig config = new GaugeConfig()
        {
            Label = "%",
            MajorTicks = 5,
            MinorTicks = 2,
            Max = 130,
            Min = 90,
            Size = 60,
            TransitionDurationMs = 600,
            GreenZones = new GaugeZone[]
            {
                new GaugeZone { From = 100, To = 130 }
            },
            YellowZones = new GaugeZone[]
            {
                new GaugeZone { From = 95, To = 100 }
            },
            RedZones = new GaugeZone[]
            {
                new GaugeZone { From = 90, To = 95 }
            },
            ValuePrecision = 2
        };

        private HarSAGauge gauge;

        protected override async Task OnInitializedAsync()
        {
            var r = new Random();

            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(300000000);
                await gauge.UpdateValue((r.NextDouble() * (103 - 80)) + 80);

            }


        }
    }
}
