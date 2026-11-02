# Exercise: The Company Org Chart

Exercise code for the lesson **Exercise: The Company Org Chart** in the course *Data Structures and Big-O, Demystified* on [ask-codey.com](https://www.ask-codey.com).

## The ticket

> **From:** HR, the bike company
>
> The org chart page in the staff app needs three things from the chart. Today we're 11 people; next year we'll be thousands, so each one should look at each person once, not reread the whole company for every name.
>
> 1. **Head count.** For any person, how many people work under them, all the way down. Ava's should say 10.
> 2. **The bottom of the chart.** Everyone at the deepest level, left to right. Today that's our two newest apprentices.
> 3. **The chart, printed.** One line per person, each team indented under its manager, two spaces for every step down from Ava.

Every person on the chart is an `Employee`: a name and a list of reports, the people who report to them. Three functions are yours to finish:

- `countUnder` (`CountUnder` in C#, `count_under` in Python): the head count, everyone under a person
- `deepestTeam` (`DeepestTeam`, `deepest_team`): the names at the bottom of the chart, left to right
- `chartLines` (`ChartLines`, `chart_lines`): the chart as indented lines of text, ready to print

## Pick your language

The same exercise is here in five languages. Work in the folder for the language you set up; you only need one.

| Folder | Your code | The tests |
|---|---|---|
| `csharp/` | `OrgChart/Chart.cs` | `OrgChart.Tests/ChartTests.cs` |
| `java/` | `src/main/java/Chart.java` | `src/test/java/ChartTest.java` |
| `python/` | `org_chart.py` | `test_org_chart.py` |
| `javascript/` | `org-chart.js` | `org-chart.test.js` |
| `typescript/` | `org-chart.ts` | `org-chart.test.ts` |

Each function returns `0` or an empty list for now. The comment above it says what it should return, with examples. Replace the `return` line with your own code, and write the function's growth rate on its **Growth rate:** line. The `Employee` class is given (in C# and Java it has a file of its own), and you don't need to change it.

Every folder also has a small demo program that prints the bike company's chart with your functions. You don't need to change the tests or the demo.

## Run it and check your work

Open your language's folder in VS Code (**File > Open Folder**), then open its terminal (**Terminal > New Terminal**) and run these commands there.

**C#**

```bash
dotnet run --project OrgChart
dotnet test
```

**Java** (the Maven Wrapper downloads Maven the first time, so the first run takes a minute)

```bash
java src/main/java/Demo.java
./mvnw test
```

On Windows in PowerShell, write `.\mvnw test` instead of `./mvnw test`.

**Python** (once: make a virtual environment and install pytest into it)

```bash
python -m venv .venv
```

Then turn it on: `.venv\Scripts\Activate.ps1` in PowerShell on Windows, or `source .venv/bin/activate` on macOS (where the command is `python3`, not `python`). Then:

```bash
pip install -r requirements.txt
python demo.py
python -m pytest
```

**JavaScript**

```bash
node demo.js
npm test
```

**TypeScript** (once: `npm install`, which installs TypeScript)

```bash
node demo.ts
npm test
```

At first every test fails: that is expected. Each function you finish turns its tests green. A failing test's message starts with **Not yet:** and says what it expected.

<details>
<summary>Stuck?</summary>

- **Each job needs its own order.** All three visit every person once; what changes is *when* a person is handled compared with their team. The lesson *Print the Chart, Count the Teams: Walking a Tree in the Right Order* has a table of which walk fits which job.
- **The head count needs the parts first.** Everyone under a person is each of their reports, plus everyone under that report. Count a report's team before you add it in: that's a **post-order** walk.
- **The bottom of the chart is about levels.** Keep one level's people in a list, and build the next level from all of their reports. When the next level would be empty, the one you have is the deepest. That's a **level-order** walk.
- **The printed chart needs each manager above their team.** Write a helper that takes a person and how deep they are: it adds the person's line, then calls itself for each report with the depth plus one. That's a **pre-order** walk.
- **Two spaces per level:** depth 0 has no spaces, depth 1 has two, depth 2 has four.

</details>

<details>
<summary>Why Should I Choose This?</summary>

Open this once your tests are green.

- **Rows of (name, manager), reread for each person:** a head count for Ava would read every row once for each person it finds: O(n²), 100 million checks at 10,000 staff.
- **Rescanning the chart once per level:** finds the bottom of the chart, but walks the whole company once for every level, O(n·h).
- **Printing a person, then their team, for the head count too:** the printed chart comes out right, but a manager's count is needed before their team has been counted, so it comes too late.
- **A tree, walked in the order the job needs:** post-order for the counts (parts before totals), level-order for the bottom (one level at a time, with a queue), pre-order for the printed chart (each manager on top of their team). Each visits every person once: O(n), however big the company gets.

</details>

## Hand it in

When it works, push your solution to a public repo of your own on GitHub, then paste that repo's address into **Submit your exercise** on the lesson page at [ask-codey.com](https://www.ask-codey.com). That's what completes the lesson. The lesson page shows the Git commands, step by step.
