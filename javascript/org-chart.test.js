// The tests for your three functions. You don't need to change this file.
// Each message says what was expected, so a failing test tells you what to look at.
import assert from "node:assert/strict";
import { test } from "node:test";
import { Employee, chartLines, countUnder, deepestTeam } from "./org-chart.js";

// The bike company: Ava at the root, with Ben, Chloe and Ivy reporting to her.
function bikeCompany() {
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

test("count under the owner", () => {
  assert.equal(countUnder(bikeCompany()), 10, "Not yet: 10 people work under Ava, everyone except Ava herself.");
});

test("count under a manager", () => {
  const ava = bikeCompany();
  assert.equal(countUnder(ava.reports[1]), 4, "Not yet: Farah, Hana, Jo and Gus work under Chloe: 4 people.");
  assert.equal(countUnder(ava.reports[0]), 2, "Not yet: Dev and Emi work under Ben: 2 people.");
  assert.equal(countUnder(ava.reports[0].reports[0]), 0, "Not yet: nobody works under Dev, a leaf.");
});

test("deepest team of the bike company", () => {
  assert.deepEqual(deepestTeam(bikeCompany()), ["Hana", "Jo"], "Not yet: Hana and Jo are the deepest, 3 steps from Ava.");
});

test("deepest team across branches", () => {
  const studio = new Employee("Rae",
    new Employee("Sam", new Employee("Tia")),
    new Employee("Uma"),
    new Employee("Vic", new Employee("Wes")));
  assert.deepEqual(deepestTeam(studio), ["Tia", "Wes"],
    "Not yet: Tia and Wes are both at the deepest level, in different branches, listed left to right.");
});

test("deepest team of one person", () => {
  assert.deepEqual(deepestTeam(new Employee("Ava")), ["Ava"], "Not yet: a chart of one person has that person as its deepest level.");
});

test("chart lines put each manager above their team", () => {
  const names = chartLines(bikeCompany()).map((line) => line.trim());
  assert.deepEqual(names, ["Ava", "Ben", "Dev", "Emi", "Chloe", "Farah", "Hana", "Jo", "Gus", "Ivy", "Kim"],
    "Not yet: each manager comes before their team, reports in the order they were added.");
});

test("chart lines indent two spaces per level", () => {
  const expected = [
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
  ];
  assert.deepEqual(chartLines(bikeCompany()), expected, "Not yet: each line starts with two spaces for every step down from Ava.");
});

test("chart lines for one person", () => {
  assert.deepEqual(chartLines(new Employee("Ava")), ["Ava"], "Not yet: a chart of one person is one line, with no spaces in front.");
});
