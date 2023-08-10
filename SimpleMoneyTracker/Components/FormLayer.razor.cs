using Microsoft.AspNetCore.Components;
using SimpleMoneyTracker.Models;
using SimpleMoneyTracker.Services;

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

        [Inject]
        private HistorySpents HistorySpents { get; set; }

        private void AddRecords()
        {
            if (_amount == 0)
                return;

            Spent newSpent = HistorySpents.CreateNewRecord(_amount, _label, _date);
            HistorySpents.InsertChronologically(newSpent);
        }

    }
}