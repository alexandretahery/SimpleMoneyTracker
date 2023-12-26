using BlazorBootstrap;
using MauiMoneyTracker.Data;
using Microsoft.AspNetCore.Components;
using MauiMoneyTracker.Services;
using Color = System.Drawing.Color;
using DatabaseMoneyTracker;

namespace MauiMoneyTracker.Components
{
    public partial class ChartLayer : IDisposable
    {

        #region Graphic
        private LineChart lineChart;

        private ChartData chartData;

        private LineChartOptions chartOptions;
        #endregion

        #region Forms
        /// <summary>Text input for the amount</summary>
        private double _amount;
        /// <summary>Text input for the date</summary>
        private DateTime _date = DateTime.Now;
        /// <summary>Text input for the label</summary>
        private string? _label;
        #endregion

        [Inject]
        private HistorySpents _historySpents { get; set; }

        /// <summary>Data used for gestion of money</summary>
        private List<Spent> _history = new List<Spent>();

        protected override void OnInitialized()
        {
            if (_historySpents is null)
                throw new NullReferenceException("HistorySpents is null");
            _historySpents.OnHistoryUpdates += OnSpentAdded;
            InitChart();
        }

        private void InitChart()
        {
            chartOptions = new LineChartOptions
            {
                Responsive = true,
                Interaction = new Interaction
                {
                    Mode = InteractionMode.Index
                },
                Plugins = new Plugins
                {
                    Title = new Title
                    {
                        Display = true,
                        Text = "Suivie des dépenses"
                    }
                },
                Scales = new Scales
                {
                    X = new ChartAxes
                    {
                        Title = new Title
                        {
                            Display = true,
                            Text = "Dates"
                        },
                        BeginAtZero = true
                    },
                    Y = new ChartAxes
                    {
                        Title = new Title
                        {
                            Display = true,
                            Text = "Euros"
                        },
                        BeginAtZero = true
                    }
                }
            };
            chartData = new ChartData
            {
                Labels = new List<string>(),
                Datasets = new List<IChartDataset>()
            };
            chartData.Datasets.Add(CreateNewLineChart());
        }

        private void OnSpentAdded(object? sender, EventArgs e)
        {
            UpdateChart(_historySpents.Spents);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {

            await lineChart.UpdateAsync(chartData, chartOptions);
            await base.OnAfterRenderAsync(firstRender);
        }

        private LineChartDataset CreateNewLineChart()
        {
            var c = Color.FromArgb(12, 78, 222);
            return new LineChartDataset()
            {
                Label = $"Dépense {chartData.Datasets.Count + 1}",
                Data = new List<double>(),
                BackgroundColor = new List<string>
                {
                    c.ToRgbString()
                },
                BorderColor = new List<string>
                {
                    c.ToRgbString()
                },
                BorderWidth = new List<double>
                {
                    2
                },
                BorderDashOffset = 1000,
                HoverBorderWidth = new List<double>
                {
                    4
                },
                PointBackgroundColor = new List<string>
                {
                    c.ToRgbString()
                },
                PointRadius = new List<int>
                {
                    0
                }, // hide points
                PointHoverRadius = new List<int>
                {
                    4
                },
            };
        }

        private async void UpdateChart(List<Spent> history)
        {
            if (chartData is null)
                return;

            List<double> HistoryUpdated = new List<double>();
            List<string> LabelUpdated = new List<string>();
            foreach (var item in history)
            {
                HistoryUpdated.Add(item.Total);
                LabelUpdated.Add(item.Date.ToString() + " " +  item.Label);
            }
            // Clear Data
            foreach (var item in chartData.Datasets)
            {
                ((LineChartDataset)item).Data.Clear();
            }

            ((LineChartDataset)chartData.Datasets[0]).Data = HistoryUpdated;
            chartData.Labels = LabelUpdated;
            await lineChart.UpdateAsync(chartData, chartOptions);
        }

        public void Dispose()
        {
            _historySpents.OnHistoryUpdates -= OnSpentAdded;
        }
    }
}