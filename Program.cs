﻿using System;

//Phase One
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.


Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Would you like to guess the secret number? (four tries)");
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
//end the loop
//error the correct display on the last try doesn't show 
int secretNumber = 36;
int numOfTries = 1;
while (numOfTries < 4)
{
    if (parsedAnswer == secretNumber)
    {
        Console.WriteLine("the guess is correct");
        return;
    }
    else
    {
        Console.WriteLine("otherwise display a failure message.");
    }
    numOfTries++;
    Console.Write($"This is guess number {(numOfTries)}: ");
    answer = Console.ReadLine();
    parsedAnswer = Int32.Parse(answer);
}
