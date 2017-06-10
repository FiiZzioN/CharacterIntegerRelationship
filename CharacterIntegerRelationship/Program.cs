// ***********************************************************************
// Assembly         : CharacterIntegerRelationship
//
// Author           : Nicholas Tyler
// Created          : 06-09-2017
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 06-10-2017
//
// License          : GNU General Public License v3.0
// ***********************************************************************

using System;

namespace CharacterIntegerRelationship
{
    public class Program
    {
        public static void Main()
        {
            IntroduceUser();

            DisplayResult(Console.ReadLine());

            Exit();
        }

        private static void Exit()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void IntroduceUser()
        {
            Console.WriteLine("This is meant to be used as a reference if you need to know what integer relates to what character, and vice versa.");
            Console.WriteLine();
            Console.WriteLine("What relation would you like to see? Type Upper, Lower, or Close to exit the program.");
        }

        private static void LowerIntegerRelations()
        {
            for (var i = 97; i < 123; i++)
            {
                Console.WriteLine($"{(char)i} = {i}");
            }
        }

        private static void UpperIntegerRelations()
        {
            for (var i = 65; i < 91; i++)
            {
                Console.WriteLine($"{(char)i} = {i}");
            }
        }

        private static void Speak(string value)
        {
            Console.WriteLine();
            Console.WriteLine(value);
        }

        private static void DisplayResult(string value)
        {
            var close = true;

            while (close)
            {
                string userInput;

                switch (value.ToLower())
                {
                    default:
                        Speak("The options are only Upper, Lower, or Close.");
                        userInput = Console.ReadLine();

                        close = false;
                        DisplayResult(userInput);
                        break;

                    case "upper":
                        Console.WriteLine();
                        UpperIntegerRelations();

                        Speak("The options are only Upper, Lower, or Close.");
                        userInput = Console.ReadLine();

                        close = false;
                        DisplayResult(userInput);
                        break;

                    case "lower":
                        Console.WriteLine();
                        LowerIntegerRelations();

                        Speak("The options are only Upper, Lower, or Close.");
                        userInput = Console.ReadLine();

                        close = false;
                        DisplayResult(userInput);
                        break;

                    case "close":
                        return;
                }
            }
        }
    }
}
