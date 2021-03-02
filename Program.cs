using System;

//Phase One
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.


Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Would you like to guess the secret number?");
Console.Write("Your Guess: ");
string answer = Console.ReadLine();
int parsedAnswer = Int32.Parse(answer);

//Phase Two
//The program should be updated to...
// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

int secretNumber = 36;

if (parsedAnswer == secretNumber)
{
    Console.WriteLine("the guess is correct");
}
else
{
    Console.WriteLine("otherwise display a failure message.");
}
