using System;
using System.Collections.Generic;

namespace Presentation
{
    public interface IStatisticsView : IView
    {
        IEnumerable<TimeSpan> RoundDurations { get; set; }
        IEnumerable<Tuple<string, TimeSpan>> TurnAverageDurations { get; set; }
    }
}