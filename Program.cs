using System;

Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("What difficulty level would you like to play on?");
Console.Write("Enter E for Easy, M for Medium, H for Hard, C for Cheater: ");
string level = Console.ReadLine().ToLower();
int triesPerLevel = 0;

if (level == "h")
{
    triesPerLevel = 3;
}
else if (level == "m")
{
    triesPerLevel = 5;
}
else if (level == "e")
{
    triesPerLevel = 7;
}
else if (level == "c")
{
    triesPerLevel = 101;
}

Console.WriteLine("Would you like to guess the secret number (1-100)?");
Console.Write("Your Guess: ");
string answer = Console.ReadLine();
int parsedAnswer = Int32.Parse(answer);

int RandomNumber()
{
    Random r = new Random();
    int genRand = r.Next(0, 19);
    // Console.WriteLine("Random Number = " + genRand);
    return genRand;
}

int secretNumber = RandomNumber();
for (int numOfTries = triesPerLevel; numOfTries > -1; numOfTries--)
{
    if (parsedAnswer == secretNumber)
    {
        Console.WriteLine("the guess is correct");
        return;
    }
    else if (parsedAnswer != secretNumber && numOfTries == 0)
    {
        Console.WriteLine("Out of Luck!");
        return;
    }
    else if (parsedAnswer > secretNumber)
    {
        Console.WriteLine("Your guess was too high.");
    }
    else if (parsedAnswer < secretNumber)
    {
        Console.WriteLine("Your guess was too low.");
    }
    Console.Write($"You have {(numOfTries)} guess left: ");
    answer = Console.ReadLine();
    parsedAnswer = Int32.Parse(answer);
}

