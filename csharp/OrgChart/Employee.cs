namespace OrgChart;

// One person on the org chart: a node of the tree. You don't need to change this file.
// Reports are the people who report to this person: the node's children.
public class Employee
{
    public string Name { get; }
    public List<Employee> Reports { get; }

    public Employee(string name, params Employee[] reports)
    {
        Name = name;
        Reports = new List<Employee>(reports);
    }
}
