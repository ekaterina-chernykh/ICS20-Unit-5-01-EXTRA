// Created by: Ekaterina
// Created on: Nov 2022
//
// This program generates random number

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userNumber;
        int randomNumber;

        // This function accepts user input
        Console.WriteLine("Can you guess my number?");
        Console.WriteLine(" ");

        Console.WriteLine("Enter random value 1 - 6 ");
        Console.WriteLine(" ");
        userNumber = Convert.ToInt16(Console.ReadLine());

        Random rnd = new Random();
        randomNumber = rnd.Next(1, 6);

        Console.WriteLine(" ");
        if (userNumber == randomNumber)
        {
            Console.WriteLine("The answer was " + randomNumber + "! You got it right!");
        }

        if (userNumber != randomNumber)
        {
            Console.WriteLine("The answer was " + randomNumber + ". You got it wrong. :(");
        }

        Console.WriteLine("\nDone.");
    }
}