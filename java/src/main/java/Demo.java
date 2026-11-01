// Tries your methods on the bike company's org chart. Run it with: java src/main/java/Demo.java
public class Demo {
    public static void main(String[] args) {
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
        Employee chloe = ava.getReports().get(1);

        System.out.println("The chart:");
        for (String line : Chart.chartLines(ava)) {
            System.out.println(line);
        }
        System.out.println("Everyone under Ava: " + Chart.countUnder(ava));
        System.out.println("Everyone under Chloe: " + Chart.countUnder(chloe));
        System.out.println("Deepest team: " + String.join(", ", Chart.deepestTeam(ava)));
    }
}
