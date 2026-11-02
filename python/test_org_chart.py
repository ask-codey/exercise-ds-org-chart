# The tests for your three functions. You don't need to change this file.
# Each message says what was expected, so a failing test tells you what to look at.
from org_chart import Employee, chart_lines, count_under, deepest_team


def bike_company():
    """The bike company: Ava at the root, with Ben, Chloe and Ivy reporting to her."""
    return Employee("Ava",
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


def test_count_under_the_owner():
    assert count_under(bike_company()) == 10, "Not yet: 10 people work under Ava, everyone except Ava herself."


def test_count_under_a_manager():
    ava = bike_company()
    assert count_under(ava.reports[1]) == 4, "Not yet: Farah, Hana, Jo and Gus work under Chloe: 4 people."
    assert count_under(ava.reports[0]) == 2, "Not yet: Dev and Emi work under Ben: 2 people."
    assert count_under(ava.reports[0].reports[0]) == 0, "Not yet: nobody works under Dev, a leaf."


def test_deepest_team_of_the_bike_company():
    assert deepest_team(bike_company()) == ["Hana", "Jo"], "Not yet: Hana and Jo are the deepest, 3 steps from Ava."


def test_deepest_team_across_branches():
    studio = Employee("Rae",
        Employee("Sam", Employee("Tia")),
        Employee("Uma"),
        Employee("Vic", Employee("Wes")))
    assert deepest_team(studio) == ["Tia", "Wes"], \
        "Not yet: Tia and Wes are both at the deepest level, in different branches, listed left to right."


def test_deepest_team_of_one_person():
    assert deepest_team(Employee("Ava")) == ["Ava"], "Not yet: a chart of one person has that person as its deepest level."


def test_chart_lines_put_each_manager_above_their_team():
    names = [line.strip() for line in chart_lines(bike_company())]
    assert names == ["Ava", "Ben", "Dev", "Emi", "Chloe", "Farah", "Hana", "Jo", "Gus", "Ivy", "Kim"], \
        "Not yet: each manager comes before their team, reports in the order they were added."


def test_chart_lines_indent_two_spaces_per_level():
    expected = [
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
    ]
    assert chart_lines(bike_company()) == expected, "Not yet: each line starts with two spaces for every step down from Ava."


def test_chart_lines_for_one_person():
    assert chart_lines(Employee("Ava")) == ["Ava"], "Not yet: a chart of one person is one line, with no spaces in front."
