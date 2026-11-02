// Your three functions. The comment above each one says what it should
// return, with examples from the bike company's chart in demo.ts.
// Replace each return line with your own code, and write the function's
// growth rate in its comment.

// One person on the org chart: a node of the tree. You don't need to change this class.
// Reports are the people who report to this person: the node's children.
export class Employee {
  name: string;
  reports: Employee[];

  constructor(name: string, ...reports: Employee[]) {
    this.name = name;
    this.reports = reports;
  }
}

/*
 * Count everyone who works under a person: their reports, their
 * reports' reports, and so on all the way down. Don't count the
 * person themselves.
 *
 * countUnder(ava) -> 10
 * countUnder(chloe) -> 4   (Farah, Hana, Jo and Gus)
 * countUnder(dev) -> 0     (a leaf: nobody reports to Dev)
 *
 * Growth rate: (write it here)
 */
export function countUnder(person: Employee): number {
  return 0;
}

/*
 * Find the deepest team: the names of everyone at the deepest level
 * of the chart, the people farthest from the root, listed left to
 * right.
 *
 * deepestTeam(ava) -> ["Hana", "Jo"]   (3 steps from Ava)
 * deepestTeam(a chart of only Ava) -> ["Ava"]
 *
 * Growth rate: (write it here)
 */
export function deepestTeam(root: Employee): string[] {
  return [];
}

/*
 * Print the chart indented: one line per person, each manager
 * before their team, reports in the order they were
 * added, with two spaces in front of a name for every step down
 * from the root.
 *
 * chartLines(ava) -> ["Ava", "  Ben", "    Dev", "    Emi", "  Chloe", ...]
 *
 * Growth rate: (write it here)
 */
export function chartLines(root: Employee): string[] {
  return [];
}
