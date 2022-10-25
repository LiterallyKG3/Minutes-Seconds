using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Title = "Minutes:Seconds";
          Random randomNumber = new Random();
          
          int sec;
          bool gameLost = false;
          int streak = 0;

          Console.WriteLine("You will be given a random amount of seconds, convert it to Minutes:Seconds\nPress Enter to proceed\n----------------------------------------------------------------------");
          Console.ReadKey();

          while (gameLost == false) {
           Console.ForegroundColor = ConsoleColor.White; 
           sec = randomNumber.Next(100,1000);
           int min = (sec/60);
           string? answer;
           string? correctAnswer;
           //"?" makes the strings nullable and removes the annoying problem markers
           
           if ((sec - min * 60) > 9) {
             correctAnswer = Convert.ToString(min + ":" + (sec - min * 60));
           }
           else {
             correctAnswer = Convert.ToString(min + ":0" + (sec - min * 60));
           }
           
           Console.WriteLine("\n" + sec + "?");

           answer = Console.ReadLine();

           if (answer == correctAnswer) {
            Console.WriteLine("Correct!\n");
            streak++;
           }
           else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou Lose!\nStreak: " + streak + "\nRetry? (Y/N)");
            gameLost = true;
            string retry;
            retry = Console.ReadLine()!; //"!" removes the annoying problem markers
            if (retry == "Y") {
              gameLost = false;
              streak = 0;
            }
            if (retry == "N") {
              Console.ForegroundColor = ConsoleColor.Gray;
              Console.WriteLine("\nPress Escape to close the game");
            }  
            if (retry != "N" && retry != "Y") {
              Console.WriteLine("\nError, \"" +  retry + "\" not recognized as a command");
              //"\" makes the program ignore the next character, this is called escaping
              //e.g. Console.WriteLine("\"These two quotation marks are not removed when i am printed\"");
            }             
           }
          }
          
          Console.ReadKey();
        }
    }
}
