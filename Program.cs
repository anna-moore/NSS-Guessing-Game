using System;

//Phase One
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.


Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Would you like to guess the secret number (1-100)?");
Console.Write("Your Guess: ");
string answer = Console.ReadLine();
int parsedAnswer = Int32.Parse(answer);

//Phase Two
//The program should be updated to...
// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

//Phase Three
//The program should be updated to...
//Give the user four chances to guess the number.
//Continue to display the success or failure messages as in phase 2

//Phase Four 
//show the number of tries 
//end the loop **
//error the correct display on the last try doesn't show 

// Phase 5
// Use a random number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.

//Phase 6 
// Inform the user if their guess was too high or too low, when they guess incorrectly.
int RandomNumber()
{
    Random r = new Random();
    int genRand = r.Next(0, 19);
    // Console.WriteLine("Random Number = " + genRand);
    return genRand;
}
int secretNumber = RandomNumber();
int numOfTries = 1;
while (numOfTries < 4)
{
    if (parsedAnswer == secretNumber)
    {
        Console.WriteLine("the guess is correct");
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
    Console.Write($"You have {(4 - numOfTries)} guess left: ");
    answer = Console.ReadLine();
    parsedAnswer = Int32.Parse(answer);
    numOfTries++;
}
