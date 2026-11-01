# Exercise: The Company Org Chart

Exercise code for the lesson **Exercise: The Company Org Chart** in the course *Data Structures and Big-O, Demystified* on [ask-codey.com](https://www.ask-codey.com).

The bike company from the *Trees* chapter has grown, and its org chart screen needs three answers. Every person on the chart is an `Employee`: a name and a list of reports, the people who report to them. There are three functions to finish:

- `countUnder` (`CountUnder` in C#, `count_under` in Python): how many people work under someone, all the way down
- `deepestTeam` (`DeepestTeam`, `deepest_team`): the names of the people at the deepest level of the chart, left to right
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

## Tips

- **Start with `countUnder`.** Everyone under a manager is each report, plus everyone under that report. That's a post-order walk: the reports' counts are ready before the manager adds them up.
- **For `deepestTeam`, walk the chart one level at a time.** Keep the current level's people in a list, and build the next level from all their reports. When the next level would be empty, the current one is the deepest.
- **For `chartLines`, pass the depth along.** A pre-order walk visits each manager before their team; give the helper that does the walking a second parameter, how deep it is, and add one each time it goes down to the reports.
- **Two spaces per level:** depth 0 has no spaces, depth 1 has two, depth 2 has four.

## Hand it in

When it works, push your solution to a public repo of your own on GitHub, then paste that repo's address into **Submit your exercise** on the lesson page at [ask-codey.com](https://www.ask-codey.com). That's what completes the lesson. The lesson page shows the Git commands, step by step.
