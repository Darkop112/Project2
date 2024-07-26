using System.Windows.Forms.DataVisualization.Charting;

public class ChartManager
{
    private readonly Chart _chart;

    public ChartManager(Chart chart)
    {
        _chart = chart;
        _chart.ChartAreas.Add(new ChartArea());
    }

    public void DisplayChart(string seriesName, SeriesChartType chartType, IEnumerable<dynamic> data, string xValueMember, string yValueMember)
    {
        _chart.Series.Clear();
        _chart.DataSource = data;

        var series = new Series
        {
            Name = seriesName,
            XValueMember = xValueMember,
            YValueMembers = yValueMember,
            ChartType = chartType
        };

        _chart.Series.Add(series);
        _chart.DataBind();
    }
}
