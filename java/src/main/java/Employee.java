import java.util.ArrayList;
import java.util.List;

// One person on the org chart: a node of the tree. You don't need to change this file.
// Reports are the people who report to this person: the node's children.
public class Employee {
    private final String name;
    private final List<Employee> reports;

    public Employee(String name, Employee... reports) {
        this.name = name;
        this.reports = new ArrayList<>(List.of(reports));
    }

    public String getName() {
        return name;
    }

    public List<Employee> getReports() {
        return reports;
    }
}
