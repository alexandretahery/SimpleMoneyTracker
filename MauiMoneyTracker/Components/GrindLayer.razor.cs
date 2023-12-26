using BlazorBootstrap;
using DatabaseMoneyTracker;
using MauiMoneyTracker.Services;
using Microsoft.AspNetCore.Components;

namespace MauiMoneyTracker.Components
{
    public partial class GrindLayer
    {
        [Inject]
        HistorySpents HistorySpents { get; set; }


        private Grid<Spent> gridSpents = default!;
        private IEnumerable<Spent> spentsHistory = default!;

        override protected void OnInitialized()
        {
            if (HistorySpents is null)
                throw new NullReferenceException("HistorySpents is null");
            HistorySpents.OnHistoryUpdates += OnHistoryUpdates;
        }

        private void OnHistoryUpdates(object? sender, EventArgs e)
        {
            gridSpents.RefreshDataAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
        }

        private async Task<GridDataProviderResult<Spent>> SpentsProvider(GridDataProviderRequest<Spent> request)
        {
            spentsHistory = (IEnumerable<Spent>)HistorySpents.Spents;
            return await Task.FromResult(request.ApplyTo(spentsHistory));
        }
    }
}