import static org.junit.jupiter.api.Assertions.assertEquals;

import java.util.List;
import org.junit.jupiter.api.Test;

// The tests for your three methods. You don't need to change this file.
// Each message says what was expected, so a failing test tells you what to look at.
class ChartTest {
    // The bike company: Ava at the root, with Ben, Chloe and Ivy reporting to her.
    private static Employee bikeCompany() {
        return new Employee("Ava",
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
    }

    @Test
    void countUnderTheOwner() {
        assertEquals(10, Chart.countUnder(bikeCompany()), "Not yet: 10 people work under Ava, everyone except Ava herself.");
    }

    @Test
    void countUnderAManager() {
        Employee ava = bikeCompany();
        assertEquals(4, Chart.countUnder(ava.getReports().get(1)), "Not yet: Farah, Hana, Jo and Gus work under Chloe: 4 people.");
        assertEquals(2, Chart.countUnder(ava.getReports().get(0)), "Not yet: Dev and Emi work under Ben: 2 people.");
        assertEquals(0, Chart.countUnder(ava.getReports().get(0).getReports().get(0)), "Not yet: nobody works under Dev, a leaf.");
    }

    @Test
    void deepestTeamOfTheBikeCompany() {
        assertEquals(List.of("Hana", "Jo"), Chart.deepestTeam(bikeCompany()),
            "Not yet: Hana and Jo are the deepest, 3 steps from Ava.");
    }

    @Test
    void deepestTeamAcrossBranches() {
        Employee studio = new Employee("Rae",
            new Employee("Sam", new Employee("Tia")),
            new Employee("Uma"),
            new Employee("Vic", new Employee("Wes")));
        assertEquals(List.of("Tia", "Wes"), Chart.deepestTeam(studio),
            "Not yet: Tia and Wes are both at the deepest level, in different branches, listed left to right.");
    }

    @Test
    void deepestTeamOfOnePerson() {
        assertEquals(List.of("Ava"), Chart.deepestTeam(new Employee("Ava")),
            "Not yet: a chart of one person has that person as its deepest level.");
    }

    @Test
    void chartLinesPutEachManagerAboveTheirTeam() {
        List<String> names = Chart.chartLines(bikeCompany()).stream().map(String::trim).toList();
        assertEquals(List.of("Ava", "Ben", "Dev", "Emi", "Chloe", "Farah", "Hana", "Jo", "Gus", "Ivy", "Kim"), names,
            "Not yet: each manager comes before their team, reports in the order they were added.");
    }

    @Test
    void chartLinesIndentTwoSpacesPerLevel() {
        List<String> expected = List.of(
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
            "    Kim");
        assertEquals(expected, Chart.chartLines(bikeCompany()),
            "Not yet: each line starts with two spaces for every step down from Ava.");
    }

    @Test
    void chartLinesForOnePerson() {
        assertEquals(List.of("Ava"), Chart.chartLines(new Employee("Ava")),
            "Not yet: a chart of one person is one line, with no spaces in front.");
    }
}
