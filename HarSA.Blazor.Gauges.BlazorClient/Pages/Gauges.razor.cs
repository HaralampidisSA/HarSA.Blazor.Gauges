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
            Size = 300,
            TransitionDurationMs = 600,
            ValuePrecision = 2
        };

        private HarSAGauge gauge;

        protected override async Task OnInitializedAsync()
        {
            var r = new Random();

            await Task.Delay(2000);
            await gauge.UpdateYellowZone(95, 120);

            await Task.Delay(2000);
            await gauge.UpdateRedZone(90, 95);

            await Task.Delay(2000);
            await gauge.UpdateGreenZone(120, 130);

            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(10000);
                await gauge.UpdateValue((r.NextDouble() * (130 - 80)) + 80);


            }
        }
    }
}
