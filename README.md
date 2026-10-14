# Programming Paradigms

AE3OP – Task 02. Programming Paradigms

Two C# console applications, each written in a different programming paradigm.

| Project | Paradigm | Description |
|---|---|---|
| [DiceGame](DiceGame/Program.cs) | Imperative | Rolls two dice (player and computer) with `Random`, prints both values and the winner. A tie re-rolls both dice. |
| [StudentInformation](StudentInformation/Program.cs) | Declarative | Reads 5 numeric grades and prints the maximum, minimum and average using LINQ aggregation functions. |

## Run

Requires the .NET 10 SDK.

```bash
dotnet run --project DiceGame
dotnet run --project StudentInformation
```

## Imperative vs. declarative

**Imperative programming** describes *how* to reach the result, as a sequence of statements that change
the program state. The Dice Game uses mutable variables (`playerRoll`, `computerRoll`, `round`, `isTie`),
a `while` loop that repeats while the rolls are equal, and `if` / `else` statements to choose the winner.

**Declarative programming** describes *what* result is wanted and leaves the "how" to the language or library.
The Student Information program collects the grades with `Enumerable.Range(...).Select(...)` and gets the
results with the LINQ aggregation functions `Max()`, `Min()` and `Average()`, with no loops,
counters or temporary sums.

## Example output

```text
Dice Game
=========

Round 1
Your roll: 5
Computer roll: 5
It's a tie! Rolling both dice again...

Round 2
Your roll: 5
Computer roll: 3

You win! (5 vs 3)
```

```text
Student Information
===================
Enter grade 1: 1
Enter grade 2: 2.5
Enter grade 3: 4
Enter grade 4: 1.5
Enter grade 5: 3

Grades: 1, 2.5, 4, 1.5, 3
Maximum grade: 4
Minimum grade: 1
Average grade: 2.40
```
