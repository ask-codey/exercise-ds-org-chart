using OrgChart;

// Tries your methods on the bike company's org chart. Run it with: dotnet run --project OrgChart
Employee ava = new Employee("Ava",
    new Employee("Ben",
        new Employee("Dev"),
        new Employee("Emi")),
    new Employee("Chloe",
        new Employee("Farah",
            new Employee("Hana"),
            new Employee("Jo")),
        new Employee("Gus")),
    new Employee("Ivy",
        new Employee("Kim")));
Employee chloe = ava.Reports[1];

Console.WriteLine("The chart:");
foreach (string line in Chart.ChartLines(ava))
{
    Console.WriteLine(line);
}
Console.WriteLine("Everyone under Ava: " + Chart.CountUnder(ava));
Console.WriteLine("Everyone under Chloe: " + Chart.CountUnder(chloe));
Console.WriteLine("Deepest team: " + string.Join(", ", Chart.DeepestTeam(ava)));
