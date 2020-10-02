using HarSA.Blazor.Gauges.Configurations;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace HarSA.Blazor.Gauges.Components
{
    public partial class HarSAGauge : IDisposable
    {
        [Inject]
        public IJSRuntime JS { get; set; }

        [Parameter]
        public GaugeConfig GaugeConfig { get; set; }

        [Parameter]
        public string ElementId { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                await Create();
            }
        }

        private async Task Create()
        {
            await JS.InvokeVoidAsync("HarGauge.interop.createGauge", ElementId, GaugeConfig);
        }

        public async Task UpdateValue(double value)
        {
            await JS.InvokeVoidAsync("HarGauge.interop.updateGaugeValue", ElementId, value);
            StateHasChanged();
        }

        public async Task UpdateRedZone(double min, double max)
        {
            await JS.InvokeVoidAsync("HarGauge.interop.updateRedZone", ElementId, min, max);
            StateHasChanged();
        }

        public async Task UpdateYellowZone(double min, double max)
        {
            await JS.InvokeVoidAsync("HarGauge.interop.updateYellowZone", ElementId, min, max);
            StateHasChanged();
        }

        public async Task UpdateGreenZone(double min, double max)
        {
            await JS.InvokeVoidAsync("HarGauge.interop.updateGreenZone", ElementId, min, max);
            StateHasChanged();
        }

        public async void Dispose()
        {
            await JS.InvokeVoidAsync("HarGauge.interop.destroyGauge", ElementId);
        }


    }
}