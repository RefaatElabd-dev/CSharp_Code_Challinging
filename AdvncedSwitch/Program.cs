using System;

namespace AdvncedSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch On Types
            CodeHelper.TellMeTheType(12);
            CodeHelper.TellMeTheType("hello");
            CodeHelper.TellMeTheType(true);
            Console.WriteLine("_____");
            //Switch Expression
            string cardName = CodeHelper.SwitchOnMultipleValues(13, "clubs");
            Console.WriteLine(cardName);
            Console.ReadLine();
        }
    }
}
