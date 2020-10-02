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
            MajorTicks = 3,
            MinorTicks = 2,
            Max = 110,
            Min = 90,
            Size = 200,
            TransitionDurationMs = 600,
            GreenZones = new GaugeZone[]
            {
                new GaugeZone { From = 100, To = 110 }
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
                await Task.Delay(3000);
                await gauge.UpdateValue((r.NextDouble() * (103 - 90)) + 90);

            }


        }
    }
}
