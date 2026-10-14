// Dice Game - Imperative Programming
// The program describes HOW to get the result: a sequence of statements
// that change the program state (variables) step by step, using a loop.

Random random = new Random();

int playerRoll = 0;
int computerRoll = 0;
int round = 0;
bool isTie = true;

Console.WriteLine("Dice Game");
Console.WriteLine("=========");

while (isTie)
{
    round++;

    // Next(1, 7) returns a number from 1 to 6 (the upper bound is exclusive).
    playerRoll = random.Next(1, 7);
    computerRoll = random.Next(1, 7);

    Console.WriteLine();
    Console.WriteLine($"Round {round}");
    Console.WriteLine($"Your roll: {playerRoll}");
    Console.WriteLine($"Computer roll: {computerRoll}");

    if (playerRoll == computerRoll)
    {
        Console.WriteLine("It's a tie! Rolling both dice again...");
    }
    else
    {
        isTie = false;
    }
}

Console.WriteLine();

if (playerRoll > computerRoll)
{
    Console.WriteLine($"You win! ({playerRoll} vs {computerRoll})");
}
else
{
    Console.WriteLine($"The computer wins! ({computerRoll} vs {playerRoll})");
}
