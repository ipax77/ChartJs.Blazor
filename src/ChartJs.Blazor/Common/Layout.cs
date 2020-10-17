using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJs.Blazor.Common
{
    /// <summary>
    /// The chart Layout Configuration.
    /// <para>Link: https://www.chartjs.org/docs/latest/configuration/layout.html </para>
    /// </summary>
    public class Layout
    {
        /// <summary>
        /// The padding to add inside the chart
        /// </summary>
        public Padding Padding { get; set; } = new Padding();
    }
}
