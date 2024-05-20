namespace Memorabilia.Domain.Constants;

public sealed class DashboardChartTypes : DomainItemConstants
{
    public static readonly DashboardChartTypes Bar = new (3, "Bar");
    public static readonly DashboardChartTypes Donut = new (4, "Donut");
    public static readonly DashboardChartTypes Pie = new (1, "Pie");
    public static readonly DashboardChartTypes StackedColumn = new (2, "Stacked Column");

    private DashboardChartTypes(int id, string name) 
        : base(id, name) { }

    public static readonly DashboardChartTypes[] All =
    [
        Bar,
        Donut,
        Pie,
        StackedColumn
    ];

    public static DashboardChartTypes Find(int id)
        => All.SingleOrDefault(dashboardChartType => dashboardChartType.Id == id);
}
