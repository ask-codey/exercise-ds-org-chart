# Your three functions. The comment inside each one says what it should
# return, with examples from the bike company's chart in demo.py.
# Replace each return line with your own code, and write the function's
# growth rate in its comment.


class Employee:
    """One person on the org chart: a node of the tree. You don't need to change this class.
    Reports are the people who report to this person: the node's children."""

    def __init__(self, name, *reports):
        self.name = name
        self.reports = list(reports)


def count_under(person):
    """
    Count everyone who works under a person: their reports, their
    reports' reports, and so on all the way down. Don't count the
    person themselves.

    count_under(ava) -> 10
    count_under(chloe) -> 4   (Farah, Hana, Jo and Gus)
    count_under(dev) -> 0     (a leaf: nobody reports to Dev)

    Growth rate: (write it here)
    """
    return 0


def deepest_team(root):
    """
    Find the deepest team: the names of everyone at the deepest level
    of the chart, the people farthest from the root, listed left to
    right.

    deepest_team(ava) -> ["Hana", "Jo"]   (3 steps from Ava)
    deepest_team(a chart of only Ava) -> ["Ava"]

    Growth rate: (write it here)
    """
    return []


def chart_lines(root):
    """
    Print the chart indented: one line per person, each manager
    before their team, reports in the order they were
    added, with two spaces in front of a name for every step down
    from the root.

    chart_lines(ava) -> ["Ava", "  Ben", "    Dev", "    Emi", "  Chloe", ...]

    Growth rate: (write it here)
    """
    return []
