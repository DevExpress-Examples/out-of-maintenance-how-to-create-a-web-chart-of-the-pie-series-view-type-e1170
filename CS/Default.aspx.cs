using System;
using DevExpress.XtraCharts;
// ...

namespace WebChartPie {
    public partial class _Default : System.Web.UI.Page {

        protected void Page_Load (object sender, EventArgs e) {
            // Create a pie series and add series to the chart.
            Series series1 = new Series("Pie Series 1", ViewType.Pie);
            WebChartControl1.Series.Add(series1);

            // Specify scale types and add points to the series.
            series1.ArgumentScaleType = ScaleType.Qualitative;
            series1.ValueScaleType = ScaleType.Numerical;
            series1.Points.Add(new SeriesPoint("USA", new double[] { 9.6 }));
            series1.Points.Add(new SeriesPoint("Canada", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("Russia", new double[] { 17.1 }));
            series1.Points.Add(new SeriesPoint("China", new double[] { 9.6 }));
            series1.Points.Add(new SeriesPoint("Brazil", new double[] { 8.5 }));

            // Specify a data filter to explode points (if necessary).
            SeriesPointFilter filter = new SeriesPointFilter(SeriesPointKey.Value_1,
                DataFilterCondition.GreaterThanOrEqual, 10);
            ((PieSeriesView)series1.View).ExplodedPointsFilters.Add(filter);
            ((PieSeriesView)series1.View).ExplodeMode = PieExplodeMode.UseFilters;

            // Specify how series points are located in a pie (if necessary).
            series1.SeriesPointsSorting = SortingMode.Ascending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Value_1;
            ((PieSeriesView)series1.View).Rotation = 90;

            // Hide the legend (if necessary).
            WebChartControl1.Legend.Visible = false;

            // Specify label behavior (if necessary).
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            series1.Label.TextPattern = "{A}: {V}";
        }

    }
}
