namespace OrgChart;

// Your three methods. The comment above each one says what it should
// return, with examples from the bike company's chart in Program.cs.
// Replace each return line with your own code, and write the method's
// growth rate in its comment.
public static class Chart
{
    /*
     * Count everyone who works under a person: their reports, their
     * reports' reports, and so on all the way down. Don't count the
     * person themselves.
     *
     * CountUnder(Ava) -> 10
     * CountUnder(Chloe) -> 4   (Farah, Hana, Jo and Gus)
     * CountUnder(Dev) -> 0     (a leaf: nobody reports to Dev)
     *
     * Growth rate: (write it here)
     */
    public static int CountUnder(Employee person)
    {
        return 0;
    }

    /*
     * Find the deepest team: the names of everyone at the deepest level
     * of the chart, the people farthest from the root, listed left to
     * right.
     *
     * DeepestTeam(Ava) -> ["Hana", "Jo"]   (3 steps from Ava)
     * DeepestTeam(a chart of only Ava) -> ["Ava"]
     *
     * Growth rate: (write it here)
     */
    public static List<string> DeepestTeam(Employee root)
    {
        return new List<string>();
    }

    /*
     * Print the chart indented: one line per person, each manager
     * before their team, reports in the order they were
     * added, with two spaces in front of a name for every step down
     * from the root.
     *
     * ChartLines(Ava) -> ["Ava", "  Ben", "    Dev", "    Emi", "  Chloe", ...]
     *
     * Growth rate: (write it here)
     */
    public static List<string> ChartLines(Employee root)
    {
        return new List<string>();
    }
}
