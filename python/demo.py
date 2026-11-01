# Tries your functions on the bike company's org chart. Run it with: python demo.py
from org_chart import Employee, chart_lines, count_under, deepest_team

ava = Employee("Ava",
    Employee("Ben",
        Employee("Dev"),
        Employee("Emi")),
    Employee("Chloe",
        Employee("Farah",
            Employee("Hana"),
            Employee("Jo")),
        Employee("Gus")),
    Employee("Ivy",
        Employee("Kim")))
chloe = ava.reports[1]

print("The chart:")
for line in chart_lines(ava):
    print(line)
print(f"Everyone under Ava: {count_under(ava)}")
print(f"Everyone under Chloe: {count_under(chloe)}")
print("Deepest team: " + ", ".join(deepest_team(ava)))
