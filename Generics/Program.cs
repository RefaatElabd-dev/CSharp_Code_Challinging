using System;
using Generics.Helpers;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics Low Level
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            int x = stack.Pop(); // x is 10
            int y = stack.Pop(); // y is 5
            Console.WriteLine(x);
            Console.WriteLine(y);

            //################################################//

            Examples.Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            //###################### typeof and Unbound Generic Types ##########################//
            // typeof and Unbound Generic Types
            Type a1 = typeof(A<>);
            Type a2 = typeof(A<,>);
            Type a3 = typeof(A<int, int>);
            #endregion

            #region IComparable Example
            int z = Extensions.Max<int>(5, 10); // 10
            string last = Extensions.Max<string>("ant", "zoo"); // zoo
            #endregion
        }
    }
}
