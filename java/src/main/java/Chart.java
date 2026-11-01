import java.util.ArrayList;
import java.util.List;

// Your three methods. The comment above each one says what it should
// return, with examples from the bike company's chart in Demo.java.
// Replace each return line with your own code, and write the method's
// growth rate in its comment.
public class Chart {
    /*
     * Count everyone who works under a person: their reports, their
     * reports' reports, and so on all the way down. Don't count the
     * person themselves.
     *
     * countUnder(Ava) -> 10
     * countUnder(Chloe) -> 4   (Farah, Hana, Jo and Gus)
     * countUnder(Dev) -> 0     (a leaf: nobody reports to Dev)
     *
     * Growth rate: (write it here)
     */
    public static int countUnder(Employee person) {
        return 0;
    }

    /*
     * Find the deepest team: the names of everyone at the deepest level
     * of the chart, the people farthest from the root, listed left to
     * right.
     *
     * deepestTeam(Ava) -> ["Hana", "Jo"]   (3 steps from Ava)
     * deepestTeam(a chart of only Ava) -> ["Ava"]
     *
     * Growth rate: (write it here)
     */
    public static List<String> deepestTeam(Employee root) {
        return new ArrayList<>();
    }

    /*
     * Print the chart indented: one line per person, each manager
     * before their team (pre-order), reports in the order they were
     * added, with two spaces in front of a name for every step down
     * from the root.
     *
     * chartLines(Ava) -> ["Ava", "  Ben", "    Dev", "    Emi", "  Chloe", ...]
     *
     * Growth rate: (write it here)
     */
    public static List<String> chartLines(Employee root) {
        return new ArrayList<>();
    }
}
