using BlazorBootstrap;
using SimpleMoneyTracker.Components.ChartLayer;
using SimpleMoneyTracker.Models;

namespace SimpleMoneyTracker.Components
{
    public partial class FormLayer
    {
        /// <summary>
        /// Text input for the amount
        /// </summary>
        private double _amount;

        /// <summary>
        /// Text input for the date
        /// </summary>
        private DateTime _date = DateTime.Now;

        /// <summary>
        /// Text input for the label
        /// </summary>
        private string? _label;

        private async Task AddRecordsAsync()
        {
            if (_amount == 0)
                return;

            //Spent newSpent = ChartLayerHelper.CreateNewRecord(_history, _amount, _label, _date);
            //ChartLayerHelper.InsertChronologically(_history, newSpent);
            //UpdateChart(_history);
            //await lineChart.UpdateAsync(chartData, chartOptions);
        }

    }
}