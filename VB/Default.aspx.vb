Imports System
Imports DevExpress.XtraCharts
' ...

Namespace WebChartPie
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a pie series and add series to the chart.
            Dim series1 As New Series("Pie Series 1", ViewType.Pie)
            WebChartControl1.Series.Add(series1)

            ' Specify scale types and add points to the series.
            series1.ArgumentScaleType = ScaleType.Qualitative
            series1.ValueScaleType = ScaleType.Numerical
            series1.Points.Add(New SeriesPoint("USA", New Double() { 9.6 }))
            series1.Points.Add(New SeriesPoint("Canada", New Double() { 10 }))
            series1.Points.Add(New SeriesPoint("Russia", New Double() { 17.1 }))
            series1.Points.Add(New SeriesPoint("China", New Double() { 9.6 }))
            series1.Points.Add(New SeriesPoint("Brazil", New Double() { 8.5 }))

            ' Specify a data filter to explode points (if necessary).
            Dim filter As New SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 10)
            CType(series1.View, PieSeriesView).ExplodedPointsFilters.Add(filter)
            CType(series1.View, PieSeriesView).ExplodeMode = PieExplodeMode.UseFilters

            ' Specify how series points are located in a pie (if necessary).
            series1.SeriesPointsSorting = SortingMode.Ascending
            series1.SeriesPointsSortingKey = SeriesPointKey.Value_1
            CType(series1.View, PieSeriesView).Rotation = 90

            ' Hide the legend (if necessary).
            WebChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Specify label behavior (if necessary).
            CType(series1.Label, PieSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns
            series1.Label.TextPattern = "{A}: {V}"
        End Sub

    End Class
End Namespace
