// Tries your functions on the bike company's org chart. Run it with: node demo.ts
import { Employee, chartLines, countUnder, deepestTeam } from "./org-chart.ts";

const ava = new Employee("Ava",
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
const chloe = ava.reports[1];

console.log("The chart:");
for (const line of chartLines(ava)) {
  console.log(line);
}
console.log(`Everyone under Ava: ${countUnder(ava)}`);
console.log(`Everyone under Chloe: ${countUnder(chloe)}`);
console.log(`Deepest team: ${deepestTeam(ava).join(", ")}`);
