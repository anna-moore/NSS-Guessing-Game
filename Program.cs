using System;


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
Console.Write(answer);