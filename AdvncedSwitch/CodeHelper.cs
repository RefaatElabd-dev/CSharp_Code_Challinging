using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvncedSwitch
{
    internal class CodeHelper
    {
        //Simple Switch 
        //switching on constants.
        static void ShowCard(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1: // Joker is -1
                    goto case 12; // In this game joker counts as queen
                default: // Executes for any other cardNumber
                    Console.WriteLine(cardNumber);
                    break;
            }
        }
        static void SequentialSwitch(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                case 12:
                case 11:
                    Console.WriteLine("Face card");
                    break;
                default:
                    Console.WriteLine("Plain card");
                    break;
            }
        }

        // switch on types
        internal static void TellMeTheType(object x) // object allows any type.
        {
            switch (x)
            {
                case int i:
                    Console.WriteLine("It's an int!");
                    Console.WriteLine($"The square of {i} is {i * i}");
                    break;
                case string s:
                    Console.WriteLine("It's a string");
                    Console.WriteLine($"The length of {s} is {s.Length}");
                    break;
                default:
                    Console.WriteLine("I don't know what x is");
                    break;
            }
        }

        // predicate a case with the when keyword
        internal static void PredicateSwitchWithWhen(object x)
        {
            switch (x)
            {//Here The Order of Cases Matter
                case bool b when b == true: // Fires only when b is true
                    Console.WriteLine("True!");
                    break;
                case bool b:
                    Console.WriteLine("False!");
                    break;
            }
        }

        //stack multiple case clauses
        internal static void StackMultipleCaseClauses(object x)
        {
            switch (x)
            {
                case float f when f > 1000:
                case double d when d > 1000:
                case decimal m when m > 1000:
                    Console.WriteLine("We can refer to x here but not f or d or m");
                    break;
                case DateTime _ :  // Care about Type not it's value
                    Console.WriteLine("We can refer to x as a DateTime");
                    break;
                case null: // Mix with null ref object
                    Console.WriteLine("Nothing here");
                    break;
            }
        }


        // Switch Expressions
        
        //Assign cardName
        internal static string GetCardName(int cardNumber)
        {
            string cardName = cardNumber switch
            {
                13 => "King",  // expressions (terminated by commas)
                12 => "Queen",
                11 => "Jack",
                _ => "Pip card" // equivalent to 'default'
            };

            return cardName;
        }

        // switch on multiple values (the tuple pattern)
        internal static string SwitchOnMultipleValues(int cardNumber, string suite)
        {
            string cardName = (cardNumber, suite) switch
            {
                (13, "spades") => "King of spades",
                (13, "clubs") => "King of clubs",
                (13, _) => "Default suite",
                (_, _) => "Default valyes"
            };

            return cardName;
        }

    }
}
