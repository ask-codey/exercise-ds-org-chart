using OrgChart;

namespace OrgChart.Tests;

// The tests for your three methods. You don't need to change this file.
// Each message says what was expected, so a failing test tells you what to look at.

[TestClass]
public class ChartTests
{
    // The bike company: Ava at the root, with Ben, Chloe and Ivy reporting to her.
    private static Employee BikeCompany() =>
        new Employee("Ava",
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

    [TestMethod]
    public void CountUnderTheOwner()
    {
        Assert.AreEqual(10, Chart.CountUnder(BikeCompany()), "Not yet: 10 people work under Ava, everyone except Ava herself.");
    }

    [TestMethod]
    public void CountUnderAManager()
    {
        Employee ava = BikeCompany();
        Assert.AreEqual(4, Chart.CountUnder(ava.Reports[1]), "Not yet: Farah, Hana, Jo and Gus work under Chloe: 4 people.");
        Assert.AreEqual(2, Chart.CountUnder(ava.Reports[0]), "Not yet: Dev and Emi work under Ben: 2 people.");
        Assert.AreEqual(0, Chart.CountUnder(ava.Reports[0].Reports[0]), "Not yet: nobody works under Dev, a leaf.");
    }

    [TestMethod]
    public void DeepestTeamOfTheBikeCompany()
    {
        CollectionAssert.AreEqual(new List<string> { "Hana", "Jo" }, Chart.DeepestTeam(BikeCompany()),
            "Not yet: Hana and Jo are the deepest, 3 steps from Ava.");
    }

    [TestMethod]
    public void DeepestTeamAcrossBranches()
    {
        Employee studio = new Employee("Rae",
            new Employee("Sam", new Employee("Tia")),
            new Employee("Uma"),
            new Employee("Vic", new Employee("Wes")));
        CollectionAssert.AreEqual(new List<string> { "Tia", "Wes" }, Chart.DeepestTeam(studio),
            "Not yet: Tia and Wes are both at the deepest level, in different branches, listed left to right.");
    }

    [TestMethod]
    public void DeepestTeamOfOnePerson()
    {
        CollectionAssert.AreEqual(new List<string> { "Ava" }, Chart.DeepestTeam(new Employee("Ava")),
            "Not yet: a chart of one person has that person as its deepest level.");
    }

    [TestMethod]
    public void ChartLinesListEveryoneInPreOrder()
    {
        List<string> names = Chart.ChartLines(BikeCompany()).Select(line => line.Trim()).ToList();
        CollectionAssert.AreEqual(new List<string> { "Ava", "Ben", "Dev", "Emi", "Chloe", "Farah", "Hana", "Jo", "Gus", "Ivy", "Kim" }, names,
            "Not yet: each manager comes before their team (pre-order), reports in the order they were added.");
    }

    [TestMethod]
    public void ChartLinesIndentTwoSpacesPerLevel()
    {
        List<string> expected = new List<string>
        {
            "Ava",
            "  Ben",
            "    Dev",
            "    Emi",
            "  Chloe",
            "    Farah",
            "      Hana",
            "      Jo",
            "    Gus",
            "  Ivy",
            "    Kim",
        };
        CollectionAssert.AreEqual(expected, Chart.ChartLines(BikeCompany()),
            "Not yet: each line starts with two spaces for every step down from Ava.");
    }

    [TestMethod]
    public void ChartLinesForOnePerson()
    {
        CollectionAssert.AreEqual(new List<string> { "Ava" }, Chart.ChartLines(new Employee("Ava")),
            "Not yet: a chart of one person is one line, with no spaces in front.");
    }
}
